(function () {
    'use strict';

    var providerId = 'routerHelper';

    angular
        .module('blocks.router')
        .provider(providerId, routerHelperProvider);

    /*@ngInject*/
    function routerHelperProvider($locationProvider, $stateProvider, $urlRouterProvider) {
        var config = {
            docTitle: undefined,
            docDescription: undefined,
            resolveAlways: {}
        };

        //check browser support
        if (!(window.history && window.history.pushState)) {
            window.location.hash = '/';
        } else {
            // $locationProvider.html5Mode(true);
            // will cause an error $location in HTML5 mode requires a tag to be present!
            // Unless you set baseUrl tag after head tag like so: <head> <base href="/">
            // to know more about setting base URL visit: https://docs.angularjs.org/error/$location/nobase
            $locationProvider.html5Mode(true).hashPrefix('!');
        }
        //$locationProvider.html5Mode(true);

        this.configure = function (cfg) {
            angular.extend(config, cfg);
        };

        this.$get = routerHelper;

        /* @ngInject */
        function routerHelper($location, $rootScope, $state, $stateParams, logger, _, authorisation, appConfig) {
            var handlingStateChangeError = false;
            var hasOtherwise = false;
            var stateCounts = {
                errors: 0,
                changes: 0
            };

            var service = {
                stateCounts: stateCounts,
                configureStates: configureStates,
                getStateMenuTree: getStateMenuTree,
                getStates: getStates,
                navigateToState: navigateToState,
                navigateToPreviousState: navigateToPreviousState,
                reloadState: reloadState,
                reloadCurrentState: reloadCurrentState,
                getCurrentState: getCurrentState,
                getPreviousState: getPreviousState,
                isCurrentState: isCurrentState,
                getStateMenuTitle: getStateMenuTitle
            };

            init();

            return service;

            // --------------- Service Methods ---------------

            function configureStates(states, otherwisePath) {
                /// <summary>
                /// Configures the states.
                /// </summary>
                /// <param name="states">The states.</param>
                /// <param name="otherwisePath">The otherwise path.</param>
                /// <returns></returns>
                states.forEach(function (state) {
                    state.config.resolve =
                      angular.extend(state.config.resolve || {}, config.resolveAlways);
                    $stateProvider.state(state.state, state.config);
                });
                if (otherwisePath && !hasOtherwise) {
                    hasOtherwise = true;
                    $urlRouterProvider.otherwise(otherwisePath);
                }
            }

            function getStateMenuTree(menuName) {
                /// <summary>
                /// Gets the state menu tree.
                /// </summary>
                /// <param name="menuName">Name of the menu.</param>
                /// <returns></returns>
                var sortedTree = [];

                if (menuName) {
                    var routes = getStates({ navigation: { menu: menuName } });
                    var tree = [];
                    _.forEach(routes, function (route) {
                        var nameParts = route.name.split('.');
                        if (nameParts[0] === 'app') {
                            // remove 'app' from name.
                            nameParts.splice(0, 1);
                        }
                        // only add menu items which the user roles are authorized to see
                        if (route.access !== undefined) {
                            var authorised = authorisation.authorize(route.access.loginRequired,
                                route.access.permissions,
                                route.access.permissionCheckType);

                            if (authorised !== 0) {
                                return;
                            }
                        }

                        if (nameParts.length > 0) {
                            // Create a new model for menu items.
                            var menuItem = {
                                name: nameParts.join('.'),
                                link: route.name,
                                icon: route.navigation.menuIcon,
                                title: route.navigation.menuTitle,
                                position: route.navigation.menuPosition
                            };
                            placeState(tree, menuItem, menuName);
                        }
                    });
                    sortedTree = _.sortBy(tree, ['position', 'title']);
                    _.forEach(sortedTree, function (menuItem) {
                        if (menuItem.children) {
                            menuItem.children = _.sortBy(menuItem.children, ['position', 'title']);
                        }
                    });
                }
                return sortedTree;
            }

            function getStates(filter) {
                /// <summary>
                /// Gets the states.
                /// </summary>
                /// <param name="filter">The filter.</param>
                /// <returns></returns>
                var states = $state.get();
                if (filter) {
                    var filteredStates = _.filter(states, filter);
                    return filteredStates;
                }
                return states;
            }

            function navigateToState(to, params, options) {
                /// <summary>
                /// Navigates to state.
                /// </summary>
                /// <param name="to">To.</param>
                /// <param name="params">The parameters.</param>
                /// <param name="options">The options.</param>
                /// <returns></returns>
                $state.go(to, params, options);
            }

            /**
             * A method that navigates to the previous state.
             * 
             * @param  {String} fallbackState - the default state if no previous state was found.
             * @param  {Object} options - state options
             * @param  {Object} params  - state parameters
             * 
             */
            function navigateToPreviousState(fallbackState, options, params) {
                if ($rootScope.previousState && $rootScope.previousState.state && ($rootScope.previousState.state.name.length > 0 || $rootScope.previousState.state.url.length > 0)) {
                    var toState = ($rootScope.previousState.state.name.length > 0) ? $rootScope.previousState.state.name : $rootScope.previousState.state.url;
                    var toStateParams = (params) ? params : $rootScope.previousState.params;
                    navigateToState(toState, toStateParams, options);
                } else if (fallbackState) {
                    navigateToState(fallbackState, params, options);
                }
            }

            /**
             * A method that force reloads the current state. All resolves are re-resolved, 
             * controllers re instantiated, and events re-fired.
             * @see https://ui-router.github.io/docs/0.3.1/#/api/ui.router.state.$state#methods_reload
             * 
             * @param  {String | state object} state
             * @return {promise}
             */
            function reloadState(state) {
                $state.reload(state);
            }

            function reloadCurrentState() {
                /// <summary>
                /// Reloads the state of the current.
                /// </summary>
                /// <returns></returns>
                reloadState($state.current.name);
            }

            function getCurrentState() {
                /// <summary>
                /// Gets the state of the current.
                /// </summary>
                /// <returns></returns>
                return $state.current;
            }

            function getPreviousState() {
                /// <summary>
                /// Gets the state of the previous.
                /// </summary>
                /// <returns></returns>
                return $rootScope.previousState;
            }
            

            function isCurrentState(stateToCompare) {
                /// <summary>
                /// Determines whether the specified state is the same as the current state.
                /// </summary>
                /// <param name="stateToCompare">The state to compare.</param>
                /// <returns></returns>
                return stateToCompare.toUpperCase() === $state.current.name.toUpperCase();
            }

            function getStateMenuTitle(stateName) {
                /// <summary>
                /// Gets the state menu title.
                /// </summary>
                /// <param name="stateName">Name of the state.</param>
                /// <returns></returns>
                var searchResult = _.first(getStates({ name: stateName }));
                return _.get(searchResult, 'navigation.menuTitle', null);
            }

            // --------------- Private Methods ---------------
            function updateDocTitle() {
                /// <summary>
                /// Updates the document title.
                /// </summary>
                /// <returns></returns>
                $rootScope.$on('$stateChangeSuccess',
                  function (event, toState) {
                      stateCounts.changes++;
                      handlingStateChangeError = false;

                      var title = config.docTitle || '';
                      if (toState.title) {
                          title = title + ': ' + toState.title;
                      }

                      var description = config.docDescription || '';
                      if (toState.description) {
                          description = toState.description;
                      }

                      $rootScope.docTitle = title; // data bind to <title>
                      $rootScope.docDescription = description;
                  }
                );
            }

            function handleRoutingErrors() {
                // Route cancellation:
                // On routing error, go to the landing page.
                // Provide an exit clause if it tries to do it twice.
                $rootScope.$on('$stateChangeError',
                  function (event, toState, toParams, fromState, fromParams, error) {
                      if (handlingStateChangeError) {
                          return;
                      }
                      stateCounts.errors++;
                      handlingStateChangeError = true;
                      var destination = (toState &&
                        (toState.title || toState.name || toState.loadedTemplateUrl)) ||
                        'unknown target';

                      var message = 'Error routing to ' + destination + '. ';
                      if (angular.isObject(error) && (error.data || error.statusText || error.status)) {
                          message = message + (error.data || '') + '. <br/>' + (error.statusText || '') +
                              ': ' + (error.status || '');
                      }
                      else if (angular.isObject(error) && error.message) {
                          message = message + error.message;
                      } else {
                          message = message + 'An unknown error occurred. (view Log for more info)';
                      }
                      logger.logWarning(message, [toState], providerId, true);
                      $location.path('/');
                  }
                );
            }

            function setStateReferances() {
                /// <summary>
                /// Sets the state references.
                /// </summary>
                /// <returns></returns>
                $rootScope.$state = $state;
                $rootScope.$stateParams = $stateParams;

                $rootScope.$on('$stateChangeSuccess', function (event, toState, toParams, fromState, fromParams, error) {
                    $rootScope.previousState = {
                        state: fromState,
                        params: fromParams
                    };
                });
            }

            function placeState(tree, state, location) {
                /// <summary>
                /// Places the state.
                /// </summary>
                /// <param name="tree">The tree.</param>
                /// <param name="state">The state.</param>
                /// <param name="location">The location.</param>
                /// <returns></returns>
                var deepLevelLink = location + '_deepLevelLink';
                var topLevelLink = location + '_topLevelLink';
                var subMenu = location + '_subMenu';
                var deepSubMenu = location + '_deepSubMenu';

                var path = state.name.split('.');
                var node = tree;
                var currPath = [];
                var deepLinks = false;

                angular.forEach(path, function (dir) {
                    currPath.push(dir);
                    var isLast = currPath.length === path.length;
                    if (isLast) {
                        //add state at current level:
                        var copiedState = angular.copy(state);
                        copiedState.menuLevel = (deepLinks) ? deepLevelLink : topLevelLink;
                        node.push(copiedState);
                    } else {
                        //next path part lays deeper
                        var currPathStr = currPath.join('.');
                        var parent;
                        angular.forEach(node, function (item) {
                            if (item.name === currPathStr) {
                                parent = item;
                                parent.menuLevel = (currPath.length === 1) ? subMenu : deepSubMenu;
                            }
                        });
                        if (parent) {
                            if (!parent.hasOwnProperty('children')) {
                                parent.children = [];
                            }
                            deepLinks = true;
                            node = parent.children;
                        } else {
                            throw 'no parent for state ' + parent + ' ' + state.name;
                        }
                    }
                });
            }

            function init() {
                // Set some reference to access them from any scope
                setStateReferances();

                handleRoutingErrors();
                updateDocTitle();
            }
        }
    }

})();

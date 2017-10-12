(function() {
    'use strict';

    var providerId = 'authorisation';

    angular
        .module('blocks.authorisation')
        .provider(providerId, authorisationProvider);

    authorisationProvider.$inject = [];

    /*@ngInject*/
    function authorisationProvider() {
        var authEnums = {
            authorised: {
                authorised: 0,
                loginRequired: 1,
                notAuthorised: 2
            },
            permissionCheckType: {
                atLeastOne: 0,
                combinationRequired: 1
            }
        };
        var config = {
            loginState: undefined,
            notAuthorisedState: undefined,
            logOutEvent: 'event::auth:logout',
            activeUserStorageNameSpace: 'activeUser'
        };

        this.configure = function(cfg) {
            angular.extend(config, cfg);
        };

        this.$get = authorisation;
        authorisation.$inject = [
            '$rootScope', 'localStore', '$injector', 'logger', '_', '$q', 'eventBus', 'UserModel', 'apiHost'
        ];

        /* @ngInject */
        function authorisation($rootScope, localStore, $injector, logger, _, $q, eventBus, userModel, apiHost) {
            var activeUser;
            var routeChangeRequiredAfterLogin = false,
                loginRedirectState;

            var service = {
                responseError: responseError,
                authorize: authorize,
                authEnums: authEnums,

                getActiveUser: getActiveUser,
                getActiveUserId: getActiveUserId,
                getTenantId: getTenantId,
                saveActiveUser: saveActiveUser,
                removeActiveUser: removeActiveUser
            };

            init();

            return service;

            // --------------- Service Methods ---------------
            function responseError(rejection) {
                if (rejection.status === 401) {
                    var rejectedUrl = rejection.config.url.toLowerCase();

                    // don't redirect to 401 if authenticate call was made.
                    if (rejectedUrl.toLowerCase().indexOf('/authenticate') === -1) {
                        // Broadcast logout event
                        eventBus.broadcast(config.logOutEvent);
                    }
                }
                return $q.reject(rejection);
            }

            function authorize(loginRequired, requiredPermissions, permissionCheckType) {
                var combinationRequired = authEnums.permissionCheckType.combinationRequired;
                var atLeastOneRequired = authEnums.permissionCheckType.atLeastOne;
                var authorised = authEnums.authorised.authorised;
                var notAuthorised = authEnums.authorised.notAuthorised;

                var result = authorised,
                    user = getActiveUser(),
                    loweredPermissions = [],
                    hasPermission = true,
                    permission,
                    i;

                if (permissionCheckType) {
                    var permCheck = permissionCheckType.toLowerCase();
                    if (permCheck === 'combination') {
                        permissionCheckType = combinationRequired;
                    } else {
                        permissionCheckType = atLeastOneRequired;
                    }
                } else {
                    permissionCheckType = atLeastOneRequired;
                }

                if (loginRequired === true && user === undefined) {
                    result = authEnums.authorised.loginRequired;
                } else if ((loginRequired === true && user !== undefined) &&
                    (requiredPermissions === undefined || requiredPermissions.length === 0)) {
                    // Login is required but no specific permissions are specified.
                    result = authorised;
                } else if (requiredPermissions) {
                    loweredPermissions = [];
                    angular.forEach(user.ResourceRoles,
                        function(permission) {
                            var role = permission.Role.RoleName;
                            loweredPermissions.push(role.toLowerCase());
                        });

                    for (i = 0; i < requiredPermissions.length; i += 1) {
                        permission = requiredPermissions[i].toLowerCase();

                        if (permissionCheckType === combinationRequired) {
                            hasPermission = hasPermission && loweredPermissions.indexOf(permission) > -1;
                            // if all the permissions are required and hasPermission is false there is no point carrying on
                            if (hasPermission === false) {
                                break;
                            }
                        } else if (permissionCheckType === atLeastOneRequired) {
                            hasPermission = loweredPermissions.indexOf(permission) > -1;
                            // if we only need one of the permissions and we have it there is no point carrying on
                            if (hasPermission) {
                                break;
                            }
                        }
                    }
                    result = hasPermission ? authorised : notAuthorised;
                }
                return result;
            }

            function getActiveUser() {
                if (activeUser) {
                    return activeUser;
                }
                var tempUser = localStore.get(config.activeUserStorageNameSpace);
                if (tempUser) {
                    tempUser.ImageUrl = tempUser.ImageUrl.replace(apiHost, '');
                    activeUser = userModel.fromJson(tempUser);
                }
                return activeUser;
            }

            function getActiveUserId() {
                var loggedOnUser = getActiveUser();
                return (loggedOnUser) ? loggedOnUser.Id : undefined;
            }

            function getTenantId() {
                var loggedOnUser = getActiveUser();
                return (loggedOnUser) ? loggedOnUser.TenantId : undefined;
            }

            function saveActiveUser(activeUserData) {
                activeUser = activeUserData;
                localStore.set(config.activeUserStorageNameSpace, activeUserData);
            }

            function removeActiveUser() {
                activeUser = undefined;
                localStore.remove(config.activeUserStorageNameSpace);
            }

            // --------------- Private Methods ---------------
            // Available Parameters: event, toState, toParams, fromState, fromParams
            function stateChangeStart(event, toState) {
                var $state = $injector.get('$state');

                if (routeChangeRequiredAfterLogin && (toState.name !== config.loginState)) {
                    routeChangeRequiredAfterLogin = false;
                    event.preventDefault();
                    $state.transitionTo(loginRedirectState);
                } else if (toState.access !== undefined) {
                    var authorised = authorize(toState.access.loginRequired,
                        toState.access.permissions,
                        toState.access.permissionCheckType);

                    if (authorised === authEnums.authorised.loginRequired) {
                        routeChangeRequiredAfterLogin = true;
                        loginRedirectState = toState.name;
                        event.preventDefault();
                        $state.transitionTo(config.loginState);
                    } else if (authorised === authEnums.authorised.notAuthorised) {
                        event.preventDefault();
                        $state.transitionTo(config.notAuthorisedState);
                    }
                }
            }

            function logout() {
                removeActiveUser();
                $injector.get('$state').transitionTo(config.loginState);
            }

            function init() {
                // State Change events
                $rootScope.$on('$stateChangeStart', stateChangeStart);

                // Listen for logout event and remove activeUser.
                $rootScope.$on(config.logOutEvent, logout);
            }
        }
    }

})();
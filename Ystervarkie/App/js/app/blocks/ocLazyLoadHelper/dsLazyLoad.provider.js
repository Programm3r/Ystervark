/*eslint-disable no-unused-vars*/
(function () {
    'use strict';

    var providerId = 'ocLazyLoadHelper';

    angular
        .module('blocks.ocLazyLoadHelper')
        .provider(providerId, ocLazyLoadHelperProvider);

    /* @ngInject */
    function ocLazyLoadHelperProvider($ocLazyLoadProvider) {
        var configOptions = {
            dependenciesList: undefined,
            ocLazyLoadConfigured: false,
            debug: false,
            events: false
        };

        /* jshint validthis:true */
        this.config = function (config) {
            // If we want to define modules configs
            if (angular.isDefined(config.dependenciesList)) {
                var userDependenciesList = config.dependenciesList;
                if (userDependenciesList !== null && typeof userDependenciesList === 'object') {
                    configOptions.dependenciesList = userDependenciesList;
                    if (userDependenciesList.hasOwnProperty('modules')) {
                        $ocLazyLoadProvider.config({
                            debug: (config.debug) ? config.debug : false,
                            events: (config.events) ? config.events : false,
                            modules: userDependenciesList.modules
                        });
                        configOptions.ocLazyLoadConfigured = true;
                    }
                }
            }
        };

        this.$get = ocLazyLoadHelper;

        /* @ngInject */
        function ocLazyLoadHelper($log, $q, $ocLazyLoad) {
            // Declare private variables
            var dependenciesList = configOptions.dependenciesList;
            var ocLazyLoadConfigured = configOptions.ocLazyLoadConfigured;

            // Expose methods and variables
            var service = {
                logDependencies: logDependencies,
                load: load,
                getDependancies: getDependancies
            };
            return service;

            // Private methods
            function logDependencies() {
                $log.debug('Dependencies List That Was Configured:', dependenciesList);
                $log.debug('ocLazyLoad Configured:', ocLazyLoadConfigured);
            }

            function getDependancies(dependencies) {
                var loadArray = [],
                    deferred = $q.defer(),
                    errorMessage = 'Error: Route resolve: Bad resource name - ';
                if (angular.isArray(dependencies)) {
                    for (var i = 0, len = dependencies.length; i < len; i++) {
                        var loadObject = loadRequiredData(dependencies[i]);
                        if (!loadObject) {
                            deferred.reject(errorMessage + dependencies[i]);
                            throw (new Error(errorMessage + dependencies[i]));
                        }
                        loadArray.push(loadObject);
                    }
                    deferred.resolve(loadArray);
                } else {
                    deferred.reject('No dependencies defined');
                }
                return deferred.promise;
            }

            function load(dependencies) {
                var deferred = $q.defer();

                getDependancies(dependencies).then(
                    function (loadArray) {
                        $ocLazyLoad.load(loadArray).then(
                            function () {
                                deferred.resolve();
                            }, function (rejection) {
                                deferred.reject(rejection);
                            });
                    }, function (error) {
                        deferred.reject(error);
                    });

                return deferred.promise;
            }

            // Private Helper Methods
            function loadRequiredData(name) {
                if (dependenciesList.modules) {
                    for (var m in dependenciesList.modules) {
                        if (dependenciesList.modules[m].name &&
                            dependenciesList.modules[m].name === name) {
                            if (ocLazyLoadConfigured) {
                                return dependenciesList.modules[m].name;
                            } else {
                                return dependenciesList.modules[m];
                            }
                        }
                    }
                }
                return dependenciesList.scripts && dependenciesList.scripts[name];
            }
        }
    }

})();

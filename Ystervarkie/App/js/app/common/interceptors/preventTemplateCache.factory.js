(function () {
    'use strict';

    var serviceId = 'preventTemplateCache';

    angular
        .module('interceptors.preventTemplateCache', [])
        .service(serviceId, preventTemplateCache);

    /* @ngInject */
    function preventTemplateCache(appConfig) {
        /// <summary>
        /// Prevents the template cache.
        /// </summary>
        /// <param name="appConfig">The application configuration.</param>
        /// <returns></returns>
        var service = {
            request: request
        };
        return service;

        function request(config) {
            /// <summary>
            /// Requests the specified configuration.
            /// </summary>
            /// <param name="config">The configuration.</param>
            /// <returns></returns>
            if (config.url.indexOfAny(['widgets', 'features']) !== -1) {
                config.url = config.url + '?_v=' + appConfig.version;
            }
            return config;
        }
    }
})();
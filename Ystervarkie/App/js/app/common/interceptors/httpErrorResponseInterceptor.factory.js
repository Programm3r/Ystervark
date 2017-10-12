(function() {
    'use strict';

    var serviceId = 'httpErrorResponseInterceptor';

    angular
        .module('interceptors.httpErrorResponseInterceptor', [])
        .factory(serviceId, httpErrorResponseInterceptor);

    /* @ngInject */
    function httpErrorResponseInterceptor($q, $injector) {
        var routerHelper;
        var service = {
            responseError: error
        };
        return service;

        // #region httpErrorResponseInterceptor Implementation
        function error(response) {
            switch (response.status) {
                case 500:
                    // To avoid recursive injection error we can only inject the routerHelper here.
                    if (!routerHelper) { routerHelper = $injector.get('routerHelper'); }
                    routerHelper.navigateToState('public.error.500', { errorResponse: response });
                    break;
            }
            return $q.reject(response);
        }
        // #endregion
    }
})();

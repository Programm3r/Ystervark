(function() {
    'use strict';

    angular
        .module('common.interceptors')
        .config(configHttpProvider);

    /* @ngInject */
    function configHttpProvider($httpProvider) {
        //Http Interceptor to check AUTH failures for XHR requests
        $httpProvider.interceptors.push('timestampMarker');
        $httpProvider.interceptors.push('httpErrorResponseInterceptor');
        //$httpProvider.interceptors.push('preventTemplateCache');
    }
})();


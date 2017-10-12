(function() {
    'use strict';

    angular
        .module('blocks.authorisation')
        .config(configAuthorisation);

    /* @ngInject */
    function configAuthorisation($httpProvider) {
        //Http Interceptor to check auth failures for xhr requests
        $httpProvider.interceptors.push('authorisation');
    }
})();
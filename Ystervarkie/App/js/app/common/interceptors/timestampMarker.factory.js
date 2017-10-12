(function() {
    'use strict';

    var serviceId = 'timestampMarker';

    angular
        .module('interceptors.timestampMarker',[])
        .service(serviceId, timestampMarker);

    /* @ngInject */
    function timestampMarker() {
        var service = {
            request : request,
            response : response
        };
        return service;

        function request (config) {
            config.requestTimestamp = new Date().getTime();
            return config;
        }

        function response(responseParam) {
            responseParam.config.responseTimestamp = new Date().getTime();
            return responseParam;
        }
    }
})();
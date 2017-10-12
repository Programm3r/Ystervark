(function () {
    'use strict';

    angular
        .module('yvApp.dataServices')
        .service('apiUrlService', apiUrlService);

    /* @ngInject */
    function apiUrlService(apiHost, apiEndPoint, logger, $q) {
        var apiBase = apiHost + apiEndPoint;
        var service = {
            apiBase: apiBase,
            apiAuthUrl: apiBase + '/Authenticate',
            
            logRequestTime: logRequestTime,
            handleErrorResponse: handleErrorResponse,
            handleSuccessRawResponse: handleSuccessRawResponse,
            handleSuccessFileResponse: handleSuccessFileResponse
        }; 
        return service;

        function logRequestTime(responceData, serviceId) {
            if (responceData && responceData.hasOwnProperty('config')) {
                var config = responceData.config;
                if (config.hasOwnProperty('responseTimestamp') &&
                    config.hasOwnProperty('requestTimestamp')) {
                    var time = (config.responseTimestamp - config.requestTimestamp) / 1000,
                        apiMethod = config.method + ' ',
                        apiCall = config.url.substr(service.apiBase.length);

                    logger.logDebug(
                        apiMethod + apiCall + ' request time:',
                        time + ' seconds.',
                        serviceId,
                        false
                    );
                }
            }
        }

        function handleErrorResponse(response, serviceId) {
            var message;
            // The API response from the server should be returned in a
            // normalized format. However, if the request was not handled by the
            // server (or what not handles properly - ex. server error), then we
            // may have to normalize it on our end, as best we can.
            if (!angular.isObject(response.data) || !response.data.Message) {
                message = 'An unknown error occurred.';
            } else {
                message = response.data.Message;
            }
            // Log Error
            logger.logError(message, response, serviceId, false);

            // Otherwise, use expected error message.
            return ($q.reject(message));
        }

        function handleSuccessRawResponse(response, serviceId) {
            logRequestTime(response, serviceId);
            return response.data.Data;
        }

        function handleSuccessFileResponse(response, serviceId) {
            logRequestTime(response, serviceId);
            return response.data;
        }
    }
})();

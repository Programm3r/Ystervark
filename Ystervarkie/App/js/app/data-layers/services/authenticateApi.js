(function() {
    'use strict';
    var serviceId = 'authenticationApi';

    angular
        .module('yvApp.dataServices')
        .factory(serviceId, authenticationApi);

    /* @ngInject */
    function authenticationApi(logger, apiUrlService, $http, $q, authorisation, UserModel) {
        var baseUrl = apiUrlService.apiAuthUrl;

        var service = {
            login: login,
            azureAdLogin: azureAdLogin,
            resetPassword: resetPassword,
            getAuthorizedUser: getAuthorizedUser
        };
        return service;

        function login(data) {
            var request = $http({
                method: 'POST',
                url: baseUrl,
                data: data
            });
            return (request.then(handleSuccessModel,
                function(error) {
                    return apiUrlService.handleErrorResponse(error, serviceId);
                }));
        }

        function azureAdLogin(data) {
            var request = $http({
                method: 'POST',
                url: baseUrl + '/AzureAdLogin',
                data: data
            });
            return (request.then(handleSuccessModel,
                function (error) {
                    return apiUrlService.handleErrorResponse(error, serviceId);
                }));
        }

        //api/Authenticate/ResetPassword?emailAddress={emailAddress}
        function resetPassword(emailAddress) {
            var params = {
                emailAddress: emailAddress
            }
            var request = $http({
                method: 'POST',
                url: baseUrl + '/ResetPassword',
                params: params
            });
            return (request.then(function(response) {
                    return apiUrlService.handleSuccessRawResponse(response, serviceId);
                },
                function(error) {
                    return apiUrlService.handleErrorResponse(error, serviceId);
                }));
        }

        function getAuthorizedUser() {
            var request = $http({
                method: 'GET',
                url: baseUrl + '/GetAuthorizedResource',
                data: data
            });
            return (request.then(handleSuccessModel,
                function(error) {
                    return apiUrlService.handleErrorResponse(error, serviceId);
                }));
        }

        // #region Private Methods

        function handleSuccessModel(response) {
            var user = UserModel.fromJson(response.data.Data);
            authorisation.saveActiveUser(user);
            return user;
        }

        // #endregion

    }
})();
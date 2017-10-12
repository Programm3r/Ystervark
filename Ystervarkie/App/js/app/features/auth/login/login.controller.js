(function() {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'LoginController';

    angular
        .module('yvApp.landing')
        .controller(controllerId, loginController);

    /* @ngInject */
    function loginController(logger, authenticationApi, routerHelper, $window, $location) {
        var vm = this;

        vm.loginModel = {};
        vm.isBusy = false;
        vm.azureAdBusy = false;
        vm.login = login;

        function activate() {

        }

        activate();

        function login(form) {
            var firstError = null;

            if (form.$invalid) {
                var field;
                for (field in form) {
                    if (form.hasOwnProperty(field)) {
                        if (field[0] !== '$') {
                            if (firstError === null && !form[field].$valid) {
                                firstError = form[field].$name;
                            }

                            if (form[field].$pristine) {
                                form[field].$dirty = true;
                            }
                        }
                    }
                }
                var elem = angular.element('.ng-invalid[name=' + firstError + ']');
                elem[0].focus();
                return;
            } else {
                vm.isBusy = true;
                authenticationApi.login(vm.loginModel, $location.search().userid, $location.search().channelId)
                    .then(onLoginSuccess, function (error) {
                        logger.notifyError(error);
                        vm.isBusy = false;
                    })['finally'](function () {

                    });
            }
        }

        function onLoginSuccess(response) {            
            // set the default tenant configuration values
            routerHelper.navigateToState('app.dashboard');
            $window.ga('set', 'userId', response.Id); // Set the user ID using signed-in user_id.
        }

    }
})();
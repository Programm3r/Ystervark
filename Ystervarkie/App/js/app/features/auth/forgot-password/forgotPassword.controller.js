(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'ForgotPasswordController';

    angular
        .module('yvApp.auth')
        .controller(controllerId, forgotPasswordController);

    /* @ngInject */
    function forgotPasswordController(logger, appConfig, authenticationApi, routerHelper) {
        var vm = this,
            log = logger.getLogFn(controllerId);

        // Initializing
        activate();

        // #region Expose the private methods

        vm.onResetPasswordTap = onResetPasswordTap;

        // #endregion

        // #region Private Methods
        function activate() {
            // Constants
            vm.hintCss = appConfig.hintCss;


            vm.title = 'Forgot Password Controller';
            vm.descriptionText = 'This is the time capture area';
        }

        function onResetPasswordTap(form) {
            var firstError = null;

            if (form.$invalid) {
                var field = null;
                for (field in form) {
                    if (field[0] !== '$') {
                        if (firstError === null && !form[field].$valid) {
                            firstError = form[field].$name;
                        }

                        if (form[field].$pristine) {
                            form[field].$dirty = true;
                        }
                    }
                }
                var elem = angular.element('.ng-invalid[name=' + firstError + ']');
                elem[0].focus();
                return;
            } else {
                resetPassword(vm.emailAddress);
            }
            
        }
        // #endregion

        function resetPassword(emailAddress) {
            vm.isBusy = true;
            authenticationApi.resetPassword(emailAddress).then(
                function (isSuccess) {
                    if (isSuccess) {
                        logger.notifySuccess('You will shortly receive an email with your new password');
                        routerHelper.navigateToState('public.login');
                    } else {
                        logger.notifyWarning('Unable to reset your password at this time');
                    }
                }, logger.notifyError)['finally'](function () {
                    vm.isBusy = false;
                });
        }
    }
})();

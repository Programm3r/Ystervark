(function () {
    'use strict';

    angular
        .module('auth.forgotPassword')
        .run(appRun);

    appRun.$inject = ['routerHelper'];
    /* @ngInject */
    function appRun(routerHelper) {
        routerHelper.configureStates(getStates());
    }

    function getStates() {
        return [
            {
                state: 'public.forgotPassword',
                config: {
                    url: '/forgot-password',
                    templateUrl: 'js/app/features/auth/forgot-password/forgot-password.html',
                    controller: 'ForgotPasswordController',
                    controllerAs: 'vm',
                    access: {
                        loginRequired: false
                    },
                    title: 'Forgot Password',
                    description: '',
                    specialClass: 'bg-gray',
                    navigation: {
                        menu: '',
                        menuPosition: 0,
                        menuIcon: 'fa-key',
                        menuTitle: 'Forgot Password'
                    }
                }
            }
        ];
    }
})();
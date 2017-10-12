(function () {
    'use strict';

    angular
        .module('auth.login')
        .run(appRun);

    appRun.$inject = ['routerHelper'];
    /* @ngInject */
    function appRun(routerHelper) {
        routerHelper.configureStates(getStates());
    }

    function getStates() {
        return [
            {
                state: 'public.login',
                config: {
                    url: '/login',
                    templateUrl: 'js/app/features/auth/login/login.html',
                    controller: 'LoginController',
                    controllerAs: 'vm',
                    access: {
                        loginRequired: false
                    },
                    title: 'Sign-in',
                    description: '',
                    specialClass: 'bg-gray',
                    navigation: {
                        menu: '',
                        menuPosition: 0,
                        menuIcon: 'fa-sign-in',
                        menuTitle: 'Sign-in'
                    }
                }
            }
        ];
    }
})();
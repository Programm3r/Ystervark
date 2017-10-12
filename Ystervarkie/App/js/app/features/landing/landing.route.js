(function () {
    'use strict';

    angular
        .module('yvApp.landing')
        .run(appRun);

    appRun.$inject = ['routerHelper'];
    /* @ngInject */
    function appRun(routerHelper) {
        routerHelper.configureStates(getStates());
    }

    function getStates() {
        return [
            {
                state: 'public.landing',
                config: {
                    url: '/',
                    templateUrl: 'js/app/features/landing/landing.html',
                    controller: 'LandingController',
                    controllerAs: 'vm',
                    resolve: {
                        /* @ngInject */
                        lazyLoad: function (ocLazyLoadHelper) {
                            return ocLazyLoadHelper.load([
                                'wow','ds6-scroll-class'
                            ]);
                        }
                    },
                    access: {
                        loginRequired: false
                    },
                    title: 'Home',
                    description: '',
                    specialClass: 'landing-page',
                    navigation: {
                        menu: '',
                        menuPosition: 0,
                        menuIcon: 'fa-home',
                        menuTitle: 'Dashboard'
                    },
                    ncyBreadcrumb: {
                        label: 'Home' // Angular-breadcrumb's configuration
                    }

                }
            }
        ];
    }
})();
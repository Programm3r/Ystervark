(function () {
    'use strict';

    angular
        .module('yvApp.core')
        .run(appRun);

    /* @ngInject */
    function appRun(routerHelper) {
        var otherwise = '/error/404';
        routerHelper.configureStates(getStates(), otherwise);
    }

    function getStates() {
        return [
            {
                state: 'public',
                config: {
                    abstract: true,
                    url: '',
                    views: {
                        app: {
                            templateUrl: 'js/app/core/layout/publicLayout.html'
                        }
                    }
                }
            },
            {
                state: 'public.error',
                config: {
                    abstract: true,
                    url: '/error',
                    params: {
                        errorResponse: null
                    },
                    template: '<div ui-view class="error-page"></div>',
                    controller: 'ErrorController',
                    controllerAs: 'vm',
                    access: {
                        loginRequired: false
                    },
                    title: 'Error',
                    description: '',
                    ncyBreadcrumb: {
                        label: 'Error'                             // Angular-breadcrumb's configuration
                    }
                }
            },
            {
                state: 'public.error.404',
                config: {
                    url: '/404',
                    templateUrl: 'js/app/core/error/error-404.html',
                    access: {
                        loginRequired: false
                    },
                    title: 'Error 404',
                    description: 'Error 404: Page not found.',
                    specialClass: 'bg-gray',
                    ncyBreadcrumb: {
                        label: 'Error 404'                                 // Angular-breadcrumb's configuration
                    }
                }
            },
            {
                state: 'public.error.500',
                config: {
                    url: '/500',
                    templateUrl: 'js/app/core/error/error-500.html',
                    access: {
                        loginRequired: false
                    },
                    title: 'Error 500',
                    description: 'Error 500 Internal server error.',
                    specialClass: 'bg-gray',
                    ncyBreadcrumb: {
                        label: 'Error 500'                                 // Angular-breadcrumb's configuration
                    }
                }
            },
            {
                state: 'app',
                config: {
                    abstract: true,
                    url: '/app',
                    views: {
                        'app': {
                            templateUrl: 'js/app/core/layout/privateLayout.html',
                            controller: 'PrivateLayoutController',
                            controllerAs: 'privateCtrl'
                        },
                        'mainNav@app': {
                            templateUrl: 'js/app/core/layout/navigation/navigation.html',
                            controller: 'NavigationController',
                            controllerAs: 'navCtrl'

                        },
                        'topNav@app': {
                            templateUrl: 'js/app/core/layout/topnavbar/topnavbar.html',
                            controller: 'TopNavbarController',
                            controllerAs: 'topNavbarCtrl'
                        },
                        'footer@app': {
                            templateUrl: 'js/app/core/layout/footer/footer.html',
                            controller: 'FooterController',
                            controllerAs: 'footerCtrl'
                        },
                        'rightNav@app': {
                            templateUrl: 'js/app/core/layout/rightSidebar/rightSidebar.html',
                            controller: 'RightSidebarController',
                            controllerAs: 'rightSidebarCtrl'
                        }
                    }
                }
            }
        ];
    }
})();

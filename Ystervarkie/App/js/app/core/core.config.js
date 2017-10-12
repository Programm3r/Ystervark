/**
 * Config for app:
 * - configureMain
 * - configLazyLoading
 * - configHttpProvider
 */

(function () {
    'use strict';

    var app = angular.module('yvApp.core');

    app.config(configureMain);
    configureMain.$inject = ['loggerProvider', 'routerHelperProvider', 'exceptionHandlerProvider', 'authorisationProvider', 'appConfig', 'enableLogging', '$injector'];
    function configureMain(loggerProvider, routerHelperProvider, exceptionHandlerProvider, authorisationProvider, appConfig, enableLogging) {
        exceptionHandlerProvider.configure({
            appErrorPrefix: appConfig.name,
            appErrorShowToast: enableLogging
        });

        loggerProvider.configure({
            enableLogging: enableLogging,
            enableToastr: enableLogging
        });

        authorisationProvider.configure(appConfig.authConfig);

        routerHelperProvider.configure({
            docTitle: appConfig.name,
            docDescription: appConfig.description,
            pageNotFoundPath: appConfig.pageNotFoundPath
        });
    }

    app.config(configLazyLoading);
    configLazyLoading.$inject = [
        'jsRequireDependencies', '$controllerProvider', '$compileProvider',
        '$filterProvider', '$provide', 'ocLazyLoadHelperProvider', 'enableLogging'];
    function configLazyLoading(jsRequireDependencies, $controllerProvider, $compileProvider, $filterProvider, $provide, ocLazyLoadHelperProvider, enableLogging) {
        app.controller = $controllerProvider.register;
        app.directive = $compileProvider.directive;
        app.filter = $filterProvider.register;
        app.factory = $provide.factory;
        app.service = $provide.service;
        app.constant = $provide.constant;
        app.value = $provide.value;

        ocLazyLoadHelperProvider.config({
            dependenciesList: jsRequireDependencies,
            debug: enableLogging
        });
    }

    app.config(configHttpProvider);
    configHttpProvider.$inject = ['$httpProvider'];
    function configHttpProvider($httpProvider) {
        $httpProvider.defaults.withCredentials = true;
        delete $httpProvider.defaults.headers.common['X-Requested-With'];

        // The $http legacy promise methods success and error have been deprecated.
        // Use the standard then method instead.
        $httpProvider.useLegacyPromiseExtensions = false;
    }

    app.config(configUiElements);
    configUiElements.$inject = ['appConfig',  'cfpLoadingBarProvider', '$breadcrumbProvider'];
    function configUiElements(appConfig, cfpLoadingBarProvider, $breadcrumbProvider) {        
        // Config Angular Breadcrumb
        // More Info: https://github.com/ncuillery/angular-breadcrumb/wiki/API-Reference#provider-breadcrumbprovider
        //$breadcrumbProvider.setOptions({
        //    prefixStateName: 'app.dashboard'
        //});

        // Loading Bar Config
        // @see: https://github.com/chieffancypants/angular-loading-bar/blob/master/README.md
        cfpLoadingBarProvider.includeBar = true;
        cfpLoadingBarProvider.includeSpinner = false;
    }

})();

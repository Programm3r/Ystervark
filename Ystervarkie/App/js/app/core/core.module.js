(function() {
    'use strict';

    angular.module('yvApp.core', [
        /*
         * Angular modules
         */
        'ngSanitize',                   // ngSanitize
        'ngCookies',                    // Reading and writing browser cookies.
        'ngTouch',                      // Provides touch events and other helpers for touch-enabled devices
        'ngAnimate',                    // support for CSS-based animations (key frames and transitions)
        'ngAria',                       // Improve Angular's default accessibility by enabling common ARIA attributes
        'ngMessages',                   // Directive that is designed to show and hide messages based on the state

        /*
         * Our reusable cross app code modules
         */
        'blocks.router',                // Route Helper
        'blocks.authorisation',         // Authorization manager
        'blocks.lodash',                // Allow the use of lodash Angular Way
        'blocks.eventBus',              // Provides a eventing mechanism when a user cna broadcast and subscribe
                                        // to application wide events.
        'blocks.storage',               // Session and local storage.
        'blocks.logger',                // Logger with toaster.
        'blocks.exception',             // App level exception handler.
        'blocks.ocLazyLoadHelper',      // Lazyload Helper

        /*
         * 3rd Party modules
         */
        'ui.router',
        'ui.bootstrap',
        'cfp.loadingBar',
        'angular-storage',                       // A storage library
        'ncy-angular-breadcrumb',                // Angular breadcrumb for ui router
        'angular.filter'                         // Bunch of useful filters for AngularJS (with no external dependencies!)
    ]);
})();

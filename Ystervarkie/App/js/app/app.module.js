(function () {
    'use strict';

    angular.module('yvApp', [
        /*
         * Everybody has access to these.
         * We could place these under every feature area,
         * but this is easier to maintain.
         */
        'yvApp.core',
        'yvApp.dataModels',       // Domain model layer
        'yvApp.dataServices',     // API
        'yvApp.common',           // General components shared in app
        'yvApp.widgets',          // Directives

        /*
         * Feature areas
         */
        'yvApp.auth',
        'yvApp.landing',
        //'yvApp.dashboard',
    ]);
})();

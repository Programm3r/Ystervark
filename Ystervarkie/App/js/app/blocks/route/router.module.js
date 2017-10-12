(function () {
    'use strict';

    angular
        .module('blocks.router', [
            'blocks.lodash',
            'yvApp.common',
            'ui.router',                    // Routing
            'oc.lazyLoad'                   // ocLazyLoad
        ]);

})();

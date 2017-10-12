(function () {
    'use strict';

    angular
        .module('common.interceptors', [
            'interceptors.timestampMarker',
            'interceptors.httpErrorResponseInterceptor',
            'interceptors.preventTemplateCache'
        ]);

})();

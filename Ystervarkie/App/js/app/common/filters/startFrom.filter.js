/**
 * start From Filter
 */
(function () {
    'use strict';

    angular
        .module('yvApp.common')
        .filter('startFrom', startFromFilter);

    startFromFilter.$inject = [];

    /*@ngInject*/
    function startFromFilter() {
        return function (input, start) {
            if (input) {
                start = +start;
                return input.slice(start);
            }
            return [];
        };
    }
})();
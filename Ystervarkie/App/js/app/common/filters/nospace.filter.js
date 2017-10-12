/**
 * html To Plaintext filter
 */
(function () {
    'use strict';

    angular
        .module('yvApp.common')
        .filter('nospace', nospaceFilter);

    nospaceFilter.$inject = [];

    /*@ngInject*/
    function nospaceFilter() {
        return function (value) {
            return (!value) ? '' : value.replace(/ /g, '');
        };
    }
})();

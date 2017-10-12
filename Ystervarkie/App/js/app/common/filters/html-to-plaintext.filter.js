/**
 * html To Plaintext filter
 */
(function () {
    'use strict';

    angular
        .module('yvApp.common')
        .filter('htmlToPlaintext', htmlToPlaintext);

    htmlToPlaintext.$inject = [];

    /*@ngInject*/
    function htmlToPlaintext() {
        return function (text) {
            return String(text).replace(/<[^>]+>/gm, '');
        };
    }
})();

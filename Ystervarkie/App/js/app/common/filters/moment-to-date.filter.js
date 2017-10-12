/**
 * moment object to date object filter
 */
(function () {
    'use strict';

    angular
        .module('yvApp.common')
        .filter('momentToDate', momentToDate);

    momentToDate.$inject = ['moment'];

    /*@ngInject*/
    function momentToDate(moment) {
        return function (momentDate) {
            if (moment.isMoment(momentDate)) {
                return momentDate.toDate();
            } else { return momentDate }
        };
    }
})();

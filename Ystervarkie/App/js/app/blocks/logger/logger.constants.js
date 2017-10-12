/**
 * Config constant
 */
/* global toastr:false, moment:false */
(function() {
    'use strict';

    angular
        .module('blocks.logger')
        .constant('toastr', toastr)
        .constant('moment', moment);

})();

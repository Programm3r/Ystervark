/**
 * Config for the logger
 */

(function() {
    'use strict';

    angular
        .module('blocks.logger')
        .config(toastrConfig);

    /* @ngInject */
    function toastrConfig(toastr, $provide, $logProvider, moment) {
        // Configure Toastr
        toastr.options = {
            'closeButton': true,
            'debug': false,
            'newestOnTop': false,
            'progressBar': true,
            'positionClass': 'toast-top-right',
            'preventDuplicates': false,
            'onclick': null,
            'showDuration': '300',
            'hideDuration': '1000',
            'timeOut': '4000',
            'extendedTimeOut': '1000',
            'showEasing': 'swing',
            'hideEasing': 'linear',
            'showMethod': 'fadeIn',
            'hideMethod': 'fadeOut',
            'closeMethod': 'fadeOut'
        };

        $provide.decorator('$log', function ($delegate) {
            //Original methods
            var origInfo = $delegate.info;
            var origLog = $delegate.log;
            var origError = $delegate.error;
            var origWarn = $delegate.warn;
            var origDebug = $delegate.debug;

            function addDateToMessage(args) {
                var argsArray = [].slice.call(args);
                argsArray[0] = [
                    moment().format('DD/MM/YYYY HH:mm:ss'),
                    ' : ',
                    argsArray[0]
                ].join('');
                return argsArray;
            }

            // Override the default behavior
            // Send on our enhanced message to the original debug method.
            $delegate.debug = function () {
                origDebug.apply(null, addDateToMessage(arguments));
            };

            $delegate.info = function () {
                if ($logProvider.debugEnabled()) {
                    origInfo.apply(null, addDateToMessage(arguments));
                }
            };

            $delegate.log = function () {
                if ($logProvider.debugEnabled()) {
                    origLog.apply(null, addDateToMessage(arguments));
                }
            };

            $delegate.error = function () {
                if ($logProvider.debugEnabled()) {
                    origError.apply(null, addDateToMessage(arguments));
                }
            };

            $delegate.warn = function () {
                if ($logProvider.debugEnabled()) {
                    origWarn.apply(null, addDateToMessage(arguments));
                }
            };

            $delegate.error = function () {
                if ($logProvider.debugEnabled()) {
                    origError.apply(null, addDateToMessage(arguments));
                }
            };
            return $delegate;
        });
    }

})();

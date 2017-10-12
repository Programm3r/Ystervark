(function () {
    'use strict';

    var providerId = 'logger';

    angular
        .module('blocks.logger')
        .provider(providerId, loggerProvider);

    loggerProvider.$inject = ['$logProvider'];

    /*@ngInject*/
    function loggerProvider($logProvider) {
        var config = {
            enableLogging: true,
            enableToastr: true
        };

        $logProvider.debugEnabled(config.enableLogging);

        this.configure = function (cfg) {
            angular.extend(config, cfg);
        };

        this.$get = loggerService;
        loggerService.$inject = ['$log', 'toastr'];
        /* @ngInject */
        function loggerService($log, toastr) {
            var service = {
                getLogFn: getLogFn,
                log: log,
                logDebug: logDebug,
                logWarning: logWarning,
                logSuccess: logSuccess,
                logError: logError,
                notify: toastr,
                notifyError: notifyError,
                notifyWarning: notifyWarning,
                notifySuccess: notifySuccess,
                notifyInfo: notifyInfo
            };
            return service;

            // --------------- Service Methods ---------------
            function getLogFn(moduleId, fnName) {
                fnName = fnName || 'log';
                switch (fnName.toLowerCase()) { // convert aliases
                    case 'success':
                        fnName = 'logSuccess'; break;
                    case 'error':
                        fnName = 'logError'; break;
                    case 'warn':
                        fnName = 'logWarning'; break;
                    case 'warning':
                        fnName = 'logWarning'; break;
                    case 'debug':
                        fnName = 'logDebug'; break;
                }

                var logFn = service[fnName] || service.logDebug;
                return function (msg, data, showToast) {
                    logFn(msg, data, moduleId, (showToast === undefined) ? true : showToast);
                };
            }

            function log(message, data, source, showToast) {
                logIt(message, data, source, showToast, 'log');
            }

            function logDebug(message, data, source, showToast) {
                logIt(message, data, source, showToast, 'debug');
            }

            function logWarning(message, data, source, showToast) {
                logIt(message, data, source, showToast, 'warning');
            }

            function logSuccess(message, data, source, showToast) {
                logIt(message, data, source, showToast, 'success');
            }

            function logError(message, data, source, showToast) {
                logIt(message, data, source, showToast, 'error');
            }

            function notifyError(message, title) {
                notifyIt(message, 'error', title);
            }

            function notifyWarning(message, title) {
                notifyIt(message, 'warning', title);
            }

            function notifySuccess(message, title) {
                notifyIt(message, 'success', title);
            }

            function notifyInfo(message, title) {
                notifyIt(message, 'info', title);
            }

            // --------------- Private Methods ---------------
            function logIt(message, data, source, showToast, toastType) {
                if (config.enableLogging) {
                    var write;

                    if (toastType === 'error') {
                        write = $log.error;
                    } else if (toastType === 'warning') {
                        write = $log.warn;
                    } else if (toastType === 'log') {
                        write = $log.log;
                    } else if (toastType === 'debug') {
                        write = $log.debug;
                    } else {
                        write = $log.info;
                    }

                    source = source ? '[' + source + ']' : '';
                    write(source, message, data);
                    if (config.enableToastr && showToast) {
                        var title = (source.length > 0) ? source : toastType;
                        notifyIt(message, toastType, title);
                    }
                }
            }

            function notifyIt(message, toastType, title) {
                if (toastType === 'error') {
                    toastr.error(message, title);
                } else if (toastType === 'warning') {
                    toastr.warning(message, title);
                } else if (toastType === 'success') {
                    toastr.success(message, title);
                } else {
                    toastr.info(message, title);
                }
            }
        }
    }

})();
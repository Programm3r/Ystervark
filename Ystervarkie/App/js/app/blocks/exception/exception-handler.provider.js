// Include in index.html so that app level exceptions are handled.
(function () {
    'use strict';

    angular
      .module('blocks.exception')
      .provider('exceptionHandler', exceptionHandlerProvider)
      .config(config);

    /**
     * Must configure the exception handling
     */
    function exceptionHandlerProvider() {
        /* jshint validthis:true */
        this.config = {
            appErrorPrefix: undefined,
            appErrorShowToast: false
        };

        this.configureErrorPrefix = function (appErrorPrefix) {
            this.config.appErrorPrefix = appErrorPrefix;
        };
        this.configureErrorShowToast = function (appErrorShowToast) {
            this.config.appErrorShowToast = appErrorShowToast;
        };
        this.configure = function (configObject) {
            this.config.appErrorPrefix = configObject.appErrorPrefix;
            this.config.appErrorShowToast = configObject.appErrorShowToast;
        };

        this.$get = function () {
            return { config: this.config };
        };
    }

    config.$inject = ['$provide'];

    /**
     * Configure by setting an optional string value for appErrorPrefix.
     * Accessible via config.appErrorPrefix (via config value).
     * @param  {Object} $provide
     */
    /* @ngInject */
    function config($provide) {
        $provide.decorator('$exceptionHandler', extendExceptionHandler);
    }

    extendExceptionHandler.$inject = ['$delegate', 'exceptionHandler', 'logger'];

    /**
     * Extend the $exceptionHandler service to also display a toast.
     * @param  {Object} $delegate
     * @param  {Object} exceptionHandler
     * @param  {Object} logger
     * @return {Function} the decorated $exceptionHandler service
     */
    function extendExceptionHandler($delegate, exceptionHandler, logger) {
        return function (exception, cause) {
            var appErrorPrefix = exceptionHandler.config.appErrorPrefix || '';
            var showToast = exceptionHandler.config.appErrorShowToast || false;
            var errorData = { exception: exception, cause: cause };
            $delegate(exception, cause);
            /**
             * Could add the error to a service's collection,
             * add errors to $rootScope, log errors to remote web server,
             * or log locally. Or throw hard. It is entirely up to you.
             * throw exception;
             *
             * @example
             *     throw { message: 'error message we added' };
             */
            logger.logError(exception.message, errorData, appErrorPrefix, showToast);
        };
    }
})();
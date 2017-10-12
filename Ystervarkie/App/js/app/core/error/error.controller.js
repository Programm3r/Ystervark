(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'ErrorController';

    angular
        .module('yvApp.core')
        .controller(controllerId, errorController);

    /* @ngInject */
    function errorController($stateParams, logger, _, moment) {
        var vm = this;
        var defaultErrorMsg = 'The server encountered something unexpected that didn\'t allow it to complete the request. We apologize.';
        var log = logger.getLogFn(controllerId, 'debug');

        // Initializing
        activate();

        // expose the private methods
        // .. add code here

        // #region Private Methods

        function activate() {
            vm.errorMessage = _.get($stateParams, 'errorResponse.data.Message', defaultErrorMsg);
        }
        // #endregion

        // #region Events

        // .. add code here ..

        // #endregion

        // #region REST Calls

        // ..... add rest calls here

        // #endregion
    }
})();

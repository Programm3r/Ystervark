(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'LandingController';

    angular
        .module('yvApp.landing')
        .controller(controllerId, landingController);

    /* @ngInject */
    function landingController(appConfig, _, moment, logger) {
        var vm = this;

        // Initializing
        activate();

        // #region Expose the private methods

        // #endregion

        // #region Private Methods

        function activate() {
            // Constants
            vm.hintCss = appConfig.hintCss;
            vm.dateFormat = appConfig.defaultDateFormat;           
        }

        // #endregion


        // #region REST Methods Calls


        // #endregion
    }
})();

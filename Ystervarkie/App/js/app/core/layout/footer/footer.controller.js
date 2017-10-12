(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'FooterController';

    angular
        .module('yvApp.core')
        .controller(controllerId, topNavbarController);

    topNavbarController.$inject = ['logger'];

    /*@ngInject*/
    function topNavbarController(logger) {
        /* jshint validthis:true */
        var vm = this,
            log = logger.getLogFn(controllerId, 'debug');

        vm.title = controllerId;
        vm.description = 'This is just boilerplate code, and this feature still needs to be implemented.';
        activate();

        // Private Methods
        function activate() {
            // Add Initializing code here.
            // log('activate','No Data',false);
        }
    }
})();

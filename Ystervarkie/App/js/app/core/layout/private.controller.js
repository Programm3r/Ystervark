(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'PrivateLayoutController';

    angular
        .module('yvApp.core')
        .controller(controllerId, appPrivate);

    appPrivate.$inject = ['logger'];

    /*@ngInject*/
    function appPrivate(logger) {
        /* jshint validthis:true */
        var vm = this;

        activate(); // initial setup

        // Private Methods
        function activate() {
            vm.title = controllerId;
            vm.description = 'This is just boilerplate code, and this feature still needs to be implemented.';
        }
    }
})();

(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'NavigationController';

    angular
        .module('yvApp.core')
        .controller(controllerId, navigationController);

    /*@ngInject*/
    function navigationController(routerHelper) {
        var vm = this;

        vm.mainMenuItems = routerHelper.getStateMenuTree('main');
        vm.stateMenuItems = routerHelper.getStateMenuTree('usermenu');
    }
})();

(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'BaseController';

    angular
        .module('yvApp.common')
        .controller(controllerId, baseController);

    /* @ngInject */
    function baseController(vm, logger, moment, appConfig) {
        // Initializing
        function activate() {
            // Constants
            vm.hintCss = appConfig.hintCss;
            vm.dateFormat = appConfig.defaultDateFormat;
            vm.numberFormat = appConfig.defaultNumberFormat;
            vm.alternativeDateFormat = appConfig.alternativeDateFormat;

            // Pagination
            vm.pager = appConfig.pager;
            vm.itemCount = vm.pager.options[2].itemCount;
            vm.predicate = null;
            vm.reverse = false;

            // Header Info
            vm.title = null;
            vm.description = null;
            setLastUpdatedDate();

            // Tabs Enumeration Configuration
            vm.tabEnumeration = {
                activeTab: 'active',
                archivedTab: 'archived'
            }
            vm.selectedTab = vm.tabEnumeration.activeTab;
        }
        activate();

        // #region Expose the private methods

        vm.getIcon = getIcon;

        vm.setHeaderInfo = setHeaderInfo;
        vm.setLastUpdatedDate = setLastUpdatedDate;

        vm.isActiveTab = isActiveTab;
        vm.changeTab = changeTab;
        vm.tabChangedAction = angular.noop;

        vm.numberOfCols = numberOfCols;

        // #endregion

        // #region Private Methods

        function getIcon(column) {
            if (vm.predicate === column) {
                return vm.reverse
                    ? 'fa-sort-alpha-desc'
                    : 'fa-sort-alpha-asc';
            }
            return '';
        }


        function setHeaderInfo(title, description) {
            vm.title = title;
            vm.description = description;
        }

        function isActiveTab(tab) {
            return vm.selectedTab === tab;
        }

        function changeTab(newTab) {
            if (vm.selectedTab === newTab) {
                return;
            }
            vm.selectedTab = newTab;
            vm.tabChangedAction();
        }

        function setLastUpdatedDate() {
            // Set the last time the data was refreshed
            vm.lastUpdated = moment();
        }

        // #endregion

        // #region REST Calls

        // .. Add code here

        // #endregion

        // #region Helper Methods

        // .. Add code here

        // #endregion

    }
})();
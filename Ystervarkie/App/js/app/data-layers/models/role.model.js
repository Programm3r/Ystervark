(function () {
    'use strict';

    var serviceId = 'RoleModel';

    angular
        .module('yvApp.dataModels')
        .factory(serviceId, roleModel);

    /* @ngInject */
    function roleModel(logger, BaseModel) {
        var logWarning = logger.getLogFn(serviceId, 'warning');

        // #region Constructor
        function RoleModel(data) {
            // Public properties, assigned to the instance ('this')
            var self = this;
            BaseModel.call(self, data);

            self.Description = data.Description;
            self.RoleDisplayName = data.RoleDisplayName;
            self.RoleName = data.RoleName;
        }
        // #endregion

        // #region Prototype Methods

        // One-way reference from subclass to superclass (instance)
        RoleModel.prototype = Object.create(BaseModel.prototype);
        RoleModel.prototype.constructor = RoleModel;

        // #endregion

        // #region Private Methods
        function isDataObjectValid(data) {
            return (
                data &&
                data.hasOwnProperty('Id') &&
                data.hasOwnProperty('Description') &&
                data.hasOwnProperty('RoleDisplayName') &&
                data.hasOwnProperty('RoleName')
            );
        }
        // #endregion

        // #region Static Methods
        RoleModel.Empty = function () {
            var data = {
                Id: 0,
                RoleName: null,
                RoleDisplayName: null,
                Description: null
            };
            return new RoleModel(data);
        };

        RoleModel.build = function (data) {
            if (!isDataObjectValid(data)) {
                if (data) {
                    logWarning('Invalid Model Data', data);
                }
                return null;
            }
            return new RoleModel(data);
        };

        RoleModel.fromJson = function (responseData) {
            if (angular.isArray(responseData)) {
                return responseData
                    .map(RoleModel.build)
                    .filter(Boolean);
            }
            return RoleModel.build(responseData);
        };
        // #endregion

        return RoleModel;
    }
})();

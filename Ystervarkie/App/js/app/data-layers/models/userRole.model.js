(function () {
    'use strict';

    var serviceId = 'UserRoleModel';

    angular
        .module('yvApp.dataModels')
        .factory(serviceId, userRoleModel);

    /* @ngInject */
    function userRoleModel(logger, BaseModel, $injector) {
        var logWarning = logger.getLogFn(serviceId, 'warning'),
            roleModel;

        // #region Constructor
        function UserRoleModel(data) {
            // To avoid recursive injection error we can only inject the ResourceModel here.
            if (!roleModel) {
                roleModel = $injector.get('RoleModel');
            }

            // Public properties, assigned to the instance ('this')
            var self = this;
            BaseModel.call(self, data);

            self.ResourceId = parseInt(data.ResourceId);
            self.RoleId = parseInt(data.RoleId);
            self.Role = roleModel.fromJson(data.Role);
        }
        // #endregion

        // #region Prototype Methods

        // One-way reference from subclass to superclass (instance)
        UserRoleModel.prototype = Object.create(BaseModel.prototype);
        UserRoleModel.prototype.constructor = UserRoleModel;

        // #endregion

        // #region Private Methods
        function isDataObjectValid(data) {
            return (
                data &&
                data.hasOwnProperty('Id') &&
                data.hasOwnProperty('ResourceId') &&
                data.hasOwnProperty('RoleId') &&
                data.hasOwnProperty('Role')
            );
        }
        // #endregion

        // #region Static Methods
        UserRoleModel.empty = function (modelData) {
            var emptyData = {
                Id: 0,
                ResourceId: 0,
                RoleId: 0,
                Role: null,
                Resource: null
            };
            var data = angular.extend({}, emptyData, modelData);
            return new UserRoleModel(data);
        };

        UserRoleModel.build = function (data) {
            if (!isDataObjectValid(data)) {
                if (data) {
                    logWarning('Invalid Model Data', data);
                }
                return null;
            }
            return new UserRoleModel(data);
        };

        UserRoleModel.fromJson = function (responseData) {
            if (angular.isArray(responseData)) {
                return responseData
                    .map(UserRoleModel.build)
                    .filter(Boolean);
            }
            return UserRoleModel.build(responseData);
        };
        // #endregion

        return UserRoleModel;
    }
})();

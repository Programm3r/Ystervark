(function () {
    'use strict';

    var serviceId = 'UserModel';

    angular
        .module('yvApp.dataModels')
        .factory(serviceId, userModel);

    /* @ngInject */
    function userModel(logger, BaseModel, appConfig) {
        var logWarning = logger.getLogFn(serviceId, 'warning');

        // #region Constructor

        function UserModel(data) {
            // Public properties, assigned to the instance ('this')
            var self = this;
            BaseModel.call(self, data);

            self.Archived = data.Archived;
            self.CellPhoneNr = data.CellPhoneNr;
            self.EmailAddress = data.EmailAddress;
            self.FullName = data.FullName;
            if (data.ImageUrl) {
                var index = data.ImageUrl.indexOf('?');
                if (index !== -1) {
                    data.ImageUrl = data.ImageUrl.substring(0, data.ImageUrl.indexOf('?'));
                }    
            }
            
            self.ImageUrl = (data.ImageUrl && data.ImageUrl.indexOf(appConfig.defaultImages.resource) === -1)
                ? data.ImageUrl + '?' + moment().format('x')
                : appConfig.defaultImages.resource;
            self.PhysicalAddressId = (data.PhysicalAddressId) ? parseInt(data.PhysicalAddressId) : null;
            self.RegionName = data.RegionName;
            self.ResourceTypeName = data.ResourceTypeName;
            self.CostCentreId = data.CostCentreId;
        }

        // #endregion

        // #region Prototype Methods

        // One-way reference from subclass to superclass (instance)
        UserModel.prototype = Object.create(BaseModel.prototype);
        UserModel.prototype.constructor = UserModel;

        // #endregion

        // #region Private Methods

        function isDataObjectValid(data) {
            return (
                data &&
                data.hasOwnProperty('Id') &&
                data.hasOwnProperty('Archived') &&
                data.hasOwnProperty('CellPhoneNr') &&
                data.hasOwnProperty('EmailAddress') &&
                data.hasOwnProperty('FullName') &&
                data.hasOwnProperty('ImageUrl') &&
                data.hasOwnProperty('PhysicalAddressId') &&
                data.hasOwnProperty('RegionName') &&
                data.hasOwnProperty('ResourceTypeName') &&
                data.hasOwnProperty('CostCentreId')
            );
        }

        // #endregion

        // #region Static Methods

        UserModel.empty = function (modelData) {
            var emptyData = {
                Id: 0,
                Archived: false,
                CellPhoneNr: null,
                EmailAddress: null,
                FullName: null,
                ImageUrl: appConfig.defaultImages.resource,
                PhysicalAddressId: null,
                RegionName: null,
                ResourceTypeName: null,
                CostCentreId: null
            };
            var data = angular.extend({}, emptyData, modelData);
            return new UserModel(data);
        };

        UserModel.build = function (data) {
            if (!isDataObjectValid(data)) {
                if (data) {
                    logWarning('Invalid Model Data', data);
                }
                return null;
            }
            return new UserModel(data);
        };

        UserModel.fromJson = function (responseData) {
            if (angular.isArray(responseData)) {
                return responseData
                    .map(UserModel.build)
                    .filter(Boolean);
            }
            return UserModel.build(responseData);
        };

        // #endregion  

        return UserModel;
    }
})();

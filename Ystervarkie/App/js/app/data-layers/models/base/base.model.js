(function () {
    'use strict';

    var serviceId = 'BaseModel';

    angular
        .module('yvApp.dataModels')
        .factory(serviceId, baseModel);

    /* @ngInject */
    function baseModel() {

        // Constructor, with class name
        function BaseModel(data) {
            // Public properties, assigned to the instance ('this')
            var self = this;
            self.Id = parseInt(data.Id);
        }

        return BaseModel;
    }
})();

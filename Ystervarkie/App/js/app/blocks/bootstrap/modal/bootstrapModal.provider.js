(function () {
    'use strict';

    var serviceId = 'bootstrapModal';

    angular
        .module('bootstrap.modal')
        .provider(serviceId, bootstrapModalProvider);

    bootstrapModalProvider.$inject = [];

    function bootstrapModalProvider() {
        // For more config options see:
        // https://angular-ui.github.io/bootstrap/#/modal
        var modalDefaults = {
            backdrop: 'static',
            keyboard: true,
            templateUrl: 'customModal.tpl.html'
        };

        var basicModalDefaults = {
            titleText: 'Title?',
            bodyText: 'Perform this action?',
            actionButtonText: 'OK',
            cancelButtonText: 'Cancel'
        };

        this.configure = function (value) {
            angular.extend(modalDefaults, value);
        };

        this.$get = bootstrapModalFactory;

        bootstrapModalFactory.$inject = ['$uibModal', '$templateCache', 'logger'];
        function bootstrapModalFactory($uibModal, $templateCache, logger) {
            // Private Variables
            var logInfo = logger.getLogFn(serviceId, 'info');
            var modalInstance = ['$uibModalInstance', 'options',
                function ($uibModalInstance, options) {
                    var vm = this;
                    vm.options = options;
                    vm.titleText = options.titleText;
                    vm.bodyText = options.bodyText;
                    vm.actionButtonText = options.actionButtonText;
                    vm.cancelButtonText = options.cancelButtonText;

                    vm.ok = okClicked;
                    vm.cancel = cancelClicked;

                    function okClicked() { $uibModalInstance.close(options); }
                    function cancelClicked() { $uibModalInstance.dismiss('cancel'); }
                }];

            // Make Use of $templateCache to save the template
            $templateCache.put('customModal.tpl.html',
            '<div class="inmodal">' +
            '    <div class="modal-header">' +
            '        <button type="button" class="close" aria-label="Close"><span aria-hidden="true" ng-click="vm.cancel()">&times;</span></button>' +
            '        <i ng-if="vm.iconClass" ng-class="vm.iconClass" class="fa modal-icon"></i>' +
            '        <h4 class="modal-title">{{vm.titleText}}</h4>' +
            '    </div>' +
            '    <div class="modal-body">' +
            '        <div ng-bind="vm.bodyText"></div>' +
            '    </div>' +
            '    <div class="modal-footer">' +
            '        <button type="button" class="btn btn-white" ng-click="vm.cancel()">{{vm.cancelButtonText || \'Cancel\'}}</button>' +
            '        <button type="button" ng-if="vm.actionButtonText" class="btn btn-primary" ng-click="vm.ok()">{{vm.actionButtonText}}</button>' +
            '    </div>' +
            '</div>');

            // Expose private methods and variables.
            var service = {
                logConfig: logConfig,
                getConfig: getConfig,
                show: show,
                showCustom: showCustom,
                showBasic: showBasic
            };
            return service;

            // Service Methods
            function logConfig() {
                logInfo('Config Settings Have Been Loged!', modalDefaults);
            }

            function getConfig() {
                return angular.copy(modalDefaults);
            }

            /**
             * Show Basic Modal (Intended for confirmation modals)
             * @param  {Object} customBasicModalOptions
             * @defaultvalue customBasicModalOptions = {
             *                                          titleText: 'Proceed?',
             *                                          bodyText: 'Perform this action?',
             *                                          actionButtonText: 'OK',
             *                                          cancelButtonText: 'Close'
             *                                         }
             * @param  {Object} customModalOptions - Override any options for modal
             */
            function showBasic(customBasicModalOptions, customModalOptions) {
                if (!customModalOptions) customModalOptions = {};
                if (!customBasicModalOptions) customBasicModalOptions = {};
                return showModal(customModalOptions, customBasicModalOptions);
            }

            /**
             * Show Modal With some predefined values
             * @param  {String} templateUrl - A path to a template representing modal's content.
             * @param  {String} modalController - Controller
             * @param  {String} objectModel - Object of data that will be sent to modal
             * @param  {Object} customModalOptions - Override any options for modal
             */
            function show(templateUrl, modalController, objectModel, customModalOptions) {
                if (!customModalOptions) customModalOptions = {};
                var modalOptions = {
                    templateUrl: templateUrl,
                    resolve: {
                        modalValues: function () {
                            return objectModel || null;
                        }
                    },
                    controller: modalController,
                    controllerAs: customModalOptions.controllerAs || 'vm'
                };

                // Map modalOptions to options passed.
                angular.extend(customModalOptions, modalOptions);

                return showCustom(customModalOptions);
            }

            /**
             * Show Custom Modal
             * @desc    Wrapper for ui-bootstrap modal, just allow you to take
             *          advarntage of defaults set in config.
             * @param   {Object} customModalDefaults - Override any options for modal
             * @see     https://angular-ui.github.io/bootstrap/#/modal
             */
            function showCustom(customModalOptions) {
                if (!customModalOptions) customModalOptions = {};
                return showModal(customModalOptions);
            }

            // Private Methods
            function showModal(customModalOptions, customBasicModalOptions) {
                //Create temp objects to work with since we're in a singleton service
                var tempModalDefaults = {};
                var tempBasicModalOptions = {};

                // Map angular-ui modal custom defaults to modal defaults defined in provider
                angular.extend(tempModalDefaults, modalDefaults, customModalOptions);

                if (customBasicModalOptions) {
                    //Map custom properties to defaults defined in service
                    angular.extend(tempBasicModalOptions, basicModalDefaults, customBasicModalOptions);

                    if (!tempModalDefaults.controller) {
                        tempModalDefaults.resolve = {
                            options: function () {
                                return tempBasicModalOptions || null;
                            }
                        };
                        tempModalDefaults.controllerAs = 'vm';
                        tempModalDefaults.controller = modalInstance;
                    }
                }

                return $uibModal.open(tempModalDefaults).result;
            }
        }
    }
})();
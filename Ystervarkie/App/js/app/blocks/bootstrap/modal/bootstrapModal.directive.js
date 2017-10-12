/**
 * Directive to create Modal.
 *
 * Usage:
 * <a bootstrap-modal-url="/modal/test1.html" modal-controller="HelloCtrl" value="yourVal" ng-init="yourVal='test'" href="#">Click here to open the modal</a>
 *
 */

(function () {
    'use strict';

    var directiveId = 'bootstrapModalUrl';

    angular
        .module('bootstrap.modal')
        .directive(directiveId, bootstrapModalUrl);

    /* @ngInject*/
    function bootstrapModalUrl($uibModal, logger, bootstrapModal) {
        var log = logger.getLogFn(directiveId,'debug');
        var directive = {
            restrict: 'A', // A: attribute
            scope: { // isolate scope
                'bootstrapModalUrl': '@', // modal view url to render the modal content
                'modalController': '@', // modal view controller (optional)
                'modalOptions': '=', // modal view options (optional)
                'value': '='
            },
            link: linker
        };
        return directive;

        function linker(scope, element, attrs) {
            var modalInstance;
            var template = [
                '<div ng-include="\'' + scope.bootstrapModalUrl + '\'"></div>'
            ].join('');

            element.bind('click', function () {
                var defaultOptions = bootstrapModal.getConfig();
                // Delete the default template.
                delete defaultOptions.templateUrl;
                // see modal reference from ui bootstrap at <http://angular-ui.github.io>
                var modalOptions = {
                    template: template,
                    resolve: {
                        params: function () {
                            return scope.value;
                        }
                    },
                    controller: scope.modalController
                };
                // Check if override options were passed.
                if (typeof (scope.modalOptions) === 'object') {
                    angular.extend(defaultOptions, modalOptions, scope.modalOptions);
                } else {
                    angular.extend(defaultOptions, modalOptions);
                }
                modalInstance = $uibModal.open(defaultOptions);

                modalInstance.result.then(
                    function (returnValue) {
                        scope.value = returnValue;
                    }
                );

            });
        }
    }
})();

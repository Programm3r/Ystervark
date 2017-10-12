/**
 * @name accessShowHide
 * @desc Show or hide element based on roles 
 * @example <div access-show-hide="admin,ProjectManager" access-permission-type="combination">Something</div>
 * 
 * @name accessIf
 * @desc ng-if based on roles 
 * @example <div access-if="admin,ProjectManager" access-permission-type="combination">Something</div>
 */

(function () {
    'use strict';
    var accessIfDirectiveName = 'accessIf';
    var accessShowHideDirectiveName = 'accessShowHide';
    var accessIfNotDirectiveName = 'accessIfNot';

    angular.module('blocks.authorisation')
        .directive(accessShowHideDirectiveName, accessShowHide)
        .directive(accessIfDirectiveName, accessIf)
        .directive(accessIfNotDirectiveName, accessIfNot);

    /* @ngInject */
    function accessShowHide(authorisation) {
        var directive = {
            restrict: 'A',
            link: linker
        };
        return directive;

        function linker(scope, element, attrs) {
            var roles = attrs.access.split(','),
                makeVisible = function () {
                    element.removeClass('hidden');
                },
                makeHidden = function () {
                    element.addClass('hidden');
                },
                determineVisibility = function (resetFirst) {
                    if (resetFirst) {
                        makeVisible();
                    }

                    if (authorisation.authorize(true, roles, attrs.accessPermissionType) === authorisation.authEnums.authorised.authorised) {
                        makeVisible();
                    } else {
                        makeHidden();
                    }
                };

            if (roles.length > 0) {
                determineVisibility(true);
            }
        }
    }

    /* @ngInject */
    function accessIf(authorisation, ngIfDirective, _) {
        var ngIf = ngIfDirective[0];
        var directive = {
            transclude: ngIf.transclude,
            priority: ngIf.priority,
            terminal: ngIf.terminal,
            restrict: ngIf.restrict,
            scope: {
                accessIf: '@'
            },
            link: linker
        };
        return directive;

        function linker(scope, element, attrs) {
            //var accessRoles = attrs[accessIfDirectiveName].split(',');
            var accessRoles = (scope.accessIf) ? scope.accessIf.split(',') : [];
            var accessPermissionType = attrs.accessPermissionType;
            var roles = [];

            if (accessRoles.length > 0) {
                // trim array values
                roles = accessRoles.map(Function.prototype.call, String.prototype.trim);
            }

            var canAccess = false;
            if (authorisation.authorize(true, roles, accessPermissionType) === authorisation.authEnums.authorised.authorised) {
                canAccess = true;
            }

            attrs.ngIf = function () {
                return canAccess;
            };
            ngIf.link.apply(ngIf, arguments);
        }
    }

    /* @ngInject */
    function accessIfNot(authorisation, ngIfDirective, _) {
        var ngIf = ngIfDirective[0];
        var directive = {
            transclude: ngIf.transclude,
            priority: ngIf.priority,
            terminal: ngIf.terminal,
            restrict: ngIf.restrict,
            scope: {
                accessIfNot: '@'
            },
            link: linker
        };
        return directive;

        function linker(scope, element, attrs) {
            //var accessRoles = attrs[accessIfNotDirectiveName].split(',');
            var accessRoles = (scope.accessIfNot) ? scope.accessIfNot.split(',') : [];
            var accessPermissionType = attrs.accessPermissionType;
            var roles = [];

            if (accessRoles.length > 0) {
                // trim array values
                roles = accessRoles.map(Function.prototype.call, String.prototype.trim);
            }

            var canAccess = false;
            if (authorisation.authorize(true, roles, accessPermissionType) !== authorisation.authEnums.authorised.authorised) {
                canAccess = true;
            }

            attrs.ngIf = function () {
                return canAccess;
            };
            ngIf.link.apply(ngIf, arguments);
        }
    }
})();

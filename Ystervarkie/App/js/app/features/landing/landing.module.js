(function() {

    angular
        .module('yvApp.landing', [
            'yvApp.core',
            'duScroll'          // Scrollspy, animated scrollTo and scroll events for angular.js
        ]).value('duScrollBottomSpy', true);
})();

(function() {
    'use strict';

    angular
        .module('yvApp.auth', [
            'yvApp.core',
            'auth.login',
            'auth.forgotPassword'
        ]);

})();

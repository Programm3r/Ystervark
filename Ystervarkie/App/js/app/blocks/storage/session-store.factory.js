(function () {
    'use strict';

    angular
        .module('blocks.storage')
        .factory('sessionStore', localStore);

    /*@ngInject*/
    function localStore(store) {
        return store.getNamespacedStore('sessionStore', 'sessionStorage');
    }

})();

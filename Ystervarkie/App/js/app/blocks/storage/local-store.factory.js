(function () {
    'use strict';

    angular
        .module('blocks.storage')
        .factory('localStore', localStore);

    /*@ngInject*/
    function localStore(store) {
        return store.getNamespacedStore('localStore', 'localStorage');
    }

})();

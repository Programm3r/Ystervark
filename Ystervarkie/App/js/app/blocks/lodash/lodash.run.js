/*eslint-disable no-unused-vars*/
(function () {
    'use strict';

    angular
        .module('blocks.lodash')
        .run(runBlock);


    runBlock.$inject = ['_'];

    /**@ngInject*/
    function runBlock(_) {
        // Make sure _ is invoked at runtime. This does nothing but force the "_" to
        // be loaded after bootstrap. This is done so the "_" factory has a chance to
        // "erase" the global reference to the lodash library.
    }
})();

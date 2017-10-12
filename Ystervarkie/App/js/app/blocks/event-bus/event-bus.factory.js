(function () {
    'use strict';

    /**
     * @ngdoc service
     * @name blocks.eventBus
     * @requires $rootScope
     *
     * @description
     * Provides a eventing mechanism when a user cna broadcast and subscribe to application wide events.
     */
    angular
        .module('blocks.eventBus')
        .factory('eventBus', eventBusFactory);

    /* @ngInject */
    function eventBusFactory ($rootScope) {
        var service = {
            subscribe: subscribe,
            broadcast: broadcast
        };
        return service;
        /**
         * @ngdoc function
         * @name subscribe
         * @methodOf blocks.eventBus
         *
         * @description
         * Subscribes a callback to the given application wide event
         *
         * @param {String} eventName The name of the event to subscribe to.
         * @param {Function} callback A callback which is fire when the event is raised.
         * @return {Function} A function that can be called to unsubscrive to the event.
         */
        function subscribe (eventName, callback) {
            return $rootScope.$on(eventName, callback);
        }

        /**
         * @ngdoc function
         * @name broadcast
         * @methodOf blocks.eventBus
         *
         * @description
         * Broadcasts the given event and data.
         *
         * @param {String} eventName The name of the event to broadcast.
         * @param {object} data A data object that will be passed along with the event.
         */
        function broadcast (eventName, data) {
            $rootScope.$emit(eventName, data);
        }
    }
}());

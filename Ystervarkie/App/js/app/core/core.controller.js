/**
 * Ystervark - Main Controller
 */
(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'CoreController';

    angular
        .module('yvApp.core')
        .controller(controllerId, coreController);

    /*@ngInject*/
    function coreController(logger, _, moment, $rootScope, cfpLoadingBar, authorisation, eventBus, appConfig, $document, $timeout, apiHost) {

        // #region coreController - Private Fields

        var vm = this,
            log = logger.getLogFn(controllerId, 'debug'),
            imagePath = _.get(appConfig, 'assetPaths.images', ''), // path to images
            isActiveUser = false;

        // #endregion

        // #region coreController - Exposed Private Methods

        vm.logOut = logOut;
        vm.activeUser = getActiveUser;
        vm.scrollToTop = scrollToTop;

        // #endregion

        // #region coreController - Activate / CTOR

        function activate() {

            vm.appConfig = appConfig;
            vm.hintCss = vm.appConfig.hintCss;
            vm.numberFormat = vm.appConfig.defaultNumberFormat;

            vm.name = appConfig.name;                                           // name of your project
            vm.description = appConfig.description;                             // brief description
            vm.version = appConfig.version;                                     // application version
            vm.loginUrl = (appConfig.appSettings && appConfig.appSettings.loginUrl) ? appConfig.appSettings.loginUrl : '/login';
            vm.author = appConfig.author;                                       // company name
            vm.website = appConfig.website;                                     // company website
            vm.multiLanguage = _.get(appConfig, 'i18N.multiLanguage', false);   // Bool - Will site be using translation.
            vm.year = new Date().getFullYear();

            vm.dateFormat = appConfig.defaultDateFormat;
            initTaskCount();

            vm.hintCss = appConfig.hintCss;
        }

        activate(); // initial setup

        // #endregion

        // #region coreController - Public Methods

        function logOut() {
            if (isActiveUser) {
                isActiveUser = false;
            }

            // broadcast logout event
            eventBus.broadcast(appConfig.authConfig.logOutEvent, authorisation.getActiveUser());
        }

        function getActiveUser() {
            var activeUser = authorisation.getActiveUser();
            if (activeUser) {
                isActiveUser = true;
            }
            return activeUser;
        }

        function scrollToTop() {
            $document.scrollTopAnimated(0, 600);
        }

        // #endregion

        // #region coreController - Private Worker Methods

        function initTaskCount() {
            vm.myMessagesCount = 0;
            vm.approvalTaskCount = 0;
            vm.myTaskCount = 0;
        }

        function bodyResized(event, value) {
            log('Body Resized', value, false);
        }
        
        function processTaskData(taskMessage) {
            // my tasks logic
            vm.myTasks = _.map(_.filter(taskMessage.AllMyTasks, ['Type', 'MyTask']), function (i) {
                return mapTaskData(i);
            });
            vm.displayedMyTasks = _.take(_.orderBy(vm.myTasks, ['Date'], ['desc']), 4);
            // approval task logic
            vm.approvalTasks = _.map(_.filter(taskMessage.AllMyTasks, ['Type', 'ApprovalTask']), function (i) {
                return mapTaskData(i);
            });
            vm.displayedApprovalTasks = _.take(_.orderBy(vm.approvalTasks, ['Date'], ['desc']), 3);
        }

        function processMessageData(myMessageData) {
            vm.myMessages = _.map(myMessageData, function (i) {
                var tmpInsertDate = moment(i.TimeStamp, appConfig.alternativeDateFormat + ' HH:mm:ss');
                i.ImageUrl = (i.ImageUrl && i.ImageUrl.indexOf(appConfig.defaultImages.resource) === -1)
                    ? i.ImageUrl + '?' + moment().format('x')
                    : appConfig.defaultImages.resource;
                i.DisplayDate = tmpInsertDate.format(appConfig.defaultDateFormat);
                i.Duration = moment.duration(moment() - tmpInsertDate).humanize();
                return i;
            });

            vm.myMessages = _.filter(vm.myMessages,
                function (f) {
                    return f.From !== authorisation.getActiveUser().ResourceId && !f.Read;
                });
            vm.myMessagesDisplayed = _.take(vm.myMessages, 4);
        }

        function mapTaskData(i) {
            var tmpInsertDate = moment(i.Date, appConfig.alternativeDateFormat + ' HH:mm:ss');
            i.DisplayDate = tmpInsertDate.format(appConfig.defaultDateFormat);
            i.Duration = moment.duration(moment() - tmpInsertDate).humanize();
            i.Time = tmpInsertDate.format('h:mm a');
            i.ImageUrl = (i.ImageUrl && i.ImageUrl.indexOf(appConfig.defaultImages.resource) === -1)
                ? i.ImageUrl + '?' + moment().format('x')
                : appConfig.defaultImages.resource;
            i.DisplayStatus = i.Status.replace(/([A-Z])/g, ' $1').trim();
            i.EntityType = i.EntityType.replace(/([A-Z])/g, ' $1').trim();
            return i;
        }
       
        // #endregion

        // #region coreController - Event Subscription

        // Subscribe to the window resize event
        eventBus.subscribe('event::body::resize', bodyResized);

        // ----------------------------------------------------------------
        // UI.Router - State Change Events
        // Read More: https://github.com/angular-ui/ui-router/wiki
        // ----------------------------------------------------------------
        $rootScope.$on('$stateChangeStart', stateChangeStart);
        $rootScope.$on('$stateChangeError', stateChangeError);

        // #endregion

        // #region coreController - State Changed Event Handlers

        // Fired when the transition begins.
        // Params passed in order: event, toState, toParams, fromState, fromParams
        function stateChangeStart() {
            //start loading bar on stateChangeStart
            cfpLoadingBar.start();
        }

        // Fired when an error occurs during transition
        // Params passed in order: event, toState, toParams, fromState, fromParams
        function stateChangeError() {
            cfpLoadingBar.complete();
        }

        // #endregion

        // #region coreController - Content Loaded Subscription & Handler

        // ----------------------------------------------------------------
        // UI.Router - View Load Events
        // Read More: https://github.com/angular-ui/ui-router/wiki
        // ----------------------------------------------------------------
        $rootScope.$on('$viewContentLoaded', viewContentLoaded);

        // Fired once the view is loaded, after the DOM is rendered.
        // The '$scope' of the view emits the event.
        // Params passed in order: event
        function viewContentLoaded(event, viewName) {
            //stop loading bar on stateChangeSuccess
            cfpLoadingBar.complete();
            // Trigger the load event to fix size.
            if (viewName === '@app') {
                log(viewName + ' view loaded and triggered \'load\' event.', '', false);
                angular.element(window).triggerHandler('load');
            }

        }

        // #endregion
    }
})();

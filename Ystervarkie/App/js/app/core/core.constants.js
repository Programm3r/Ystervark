/**
 * Config constant
 */

/* global moment:false, appCoreConfig:false */
(function () {
    'use strict';

    var assetPaths = {
        images: '/images',
        scripts: '',
        downloads: ''
    }

    var appConfig = {
        name: 'Ystervark',
        description: 'Asp.NET Core 2 Web API + AngularJS Front-end',
        version: '1.0.0',
        companyName: 'Ystervark Team',
        website: 'https://github.com/Programm3r/Ystervark',
        pageNotFoundPath: '/error/404',
        defaultImages: {
            resource: assetPaths.images + '/yv-default-resource.png',
            client: assetPaths.images + '/yv-default-client.png',
            timer: assetPaths.images + '/running-timer.gif'
        },
        authConfig: {
            logOutEvent: 'event::auth:logout',
            logInEvent: 'event::auth:login',
            loginState: 'public.login',
            notAuthorisedState: 'public.error.401'
        },
        assetPaths: assetPaths,
        pager: {
            options: [
                {
                    itemIndex: 'all',
                    itemCount: 10000000,
                    itemText: 'all items'
                },
                {
                    itemIndex: '5',
                    itemCount: 5,
                    itemText: '5 items'
                },
                {
                    itemIndex: '10',
                    itemCount: 10,
                    itemText: '10 items'
                },
                {
                    itemIndex: '25',
                    itemCount: 25,
                    itemText: '25 items'
                },
                {
                    itemIndex: '50',
                    itemCount: 50,
                    itemText: '50 items'
                },
                {
                    itemIndex: '100',
                    itemCount: 100,
                    itemText: '100 items'
                }
            ]
        },
        hintCss: {
            t: 'hint--rounded hint--bounce hint--top',
            ti: 'hint--rounded hint--bounce hint--top hint--info',
            tw: 'hint--rounded hint--bounce hint--top hint--warning',
            tl: 'hint--rounded hint--bounce hint--top-left',
            tr: 'hint--rounded hint--bounce hint--top-right',
            tri: 'hint--rounded hint--bounce hint--top-right hint--info',
            trw: 'hint--rounded hint--bounce hint--top-right hint--warning',
            tre: 'hint--rounded hint--bounce hint--top-right hint--error',
            tle: 'hint--rounded hint--bounce hint--top-left hint--error',
            b: 'hint--rounded hint--bounce hint--bottom',
            bi: 'hint--rounded hint--bounce hint--bottom hint--info',
            be: 'hint--rounded hint--bounce hint--bottom hint--error',
            bl: 'hint--rounded hint--bounce hint--bottom-left',
            bli: 'hint--rounded hint--bounce hint--bottom-left hint--info',
            br: 'hint--rounded hint--bounce hint--bottom-right',
            l: 'hint--rounded hint--bounce hint--left',
            r: 'hint--rounded hint--bounce hint--right',
            ri: 'hint--rounded hint--bounce hint--right hint--info',
            rw: 'hint--rounded hint--bounce hint--right hint--warning',
            tm: 'hint--rounded hint--bounce hint--top hint--medium',
            tmi: 'hint--rounded hint--bounce hint--top hint--medium hint--info',
            tlm: 'hint--rounded hint--bounce hint--top-left hint--medium',
            tlw: 'hint--rounded hint--bounce hint--top-left hint--warning',
            tli: 'hint--rounded hint--bounce hint--top-left hint--info'
        },
        fileExtensionLookup: [
            {
                extension: '.docx',
                mimeType: 'application/vnd.openxmlformats-officedocument.wordprocessingml.document',
                icon: 'fa fa-file-word-o'
            },
            {
                extension: '.doc',
                mimeType: 'application/msword',
                icon: 'fa fa-file-word-o'
            },
            {
                extension: '.dotx',
                mimeType: 'application/vnd.openxmlformats-officedocument.wordprocessingml.template',
                icon: 'fa fa-file-word-o'
            },
            {
                extension: '.xls',
                mimeType: 'application/vnd.ms-excel',
                icon: 'fa fa-file-excel-o'
            },
            {
                extension: '.xlsx',
                mimeType: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet',
                icon: 'fa fa-file-excel-o'
            },
            {
                extension: '.xltx',
                mimeType: 'application/vnd.openxmlformats-officedocument.spreadsheetml.template',
                icon: 'fa fa-file-excel-o'
            },
            {
                extension: '.ppt',
                mimeType: 'application/vnd.ms-powerpoint',
                icon: 'fa fa-file-powerpoint-o'
            },
            {
                extension: '.pps',
                mimeType: 'application/vnd.ms-powerpoint',
                icon: 'fa fa-file-powerpoint-o'
            },
            {
                extension: '.pptx',
                mimeType: 'application/vnd.openxmlformats-officedocument.presentationml.presentation',
                icon: 'fa fa-file-powerpoint-o'
            },
            {
                extension: '.pdf',
                mimeType: 'application/pdf',
                icon: 'fa fa-file-pdf-o'
            },
            {
                extension: '.zip',
                mimeType: 'application/zip',
                icon: 'fa fa-file-archive-o'
            },
            {
                extension: '.zip',
                mimeType: 'application/x-compressed',
                icon: 'fa fa-file-archive-o'
            },
            {
                extension: '.zip',
                mimeType: 'application/x-zip-compressed',
                icon: 'fa fa-file-archive-o'
            },
            {
                extension: '.txt',
                mimeType: 'text/plain',
                icon: 'fa fa-file-text-o'
            }
        ]
    };

    // Extend appConfig - set in the dotnet Core appdettings.js
    // that is exposed in the _LayoutView.cshtml
    angular.extend(appConfig, appCoreConfig);

    var apiHost = (appConfig.api && appConfig.api.hasOwnProperty('host')) ? appConfig.api.host : 'http://localhost';
    var apiEndPoint = (appConfig.api && appConfig.api.hasOwnProperty('endPoint')) ? appConfig.api.endPoint : '/Ystervark.API/api';
    var enableLogging = (appConfig.appSettings && appConfig.appSettings.hasOwnProperty('enableLogging')) ? appConfig.appSettings.enableLogging : true;

    // These file locations are originally set in the 'gulpConfig.js'
    // @see 'config.destPaths'
    var bowerRoot = '/libs';
    var libsRoot = '/libs';

    // All files that are available for lazy-loading.
    var jsRequireDependencies = {
        //**************************************************************
        //*** Scripts
        //**************************************************************
        scripts: {
            //*** Javascript Plugins
            //**************************************************************
            'wow': [bowerRoot + '/wow/dist/wow.js']
        },

        //**************************************************************
        //*** AngularJS Modules
        //**************************************************************
        modules: [
            {
                // @desc Angular directive for collapsible JSON in HTML
                // @see https://github.com/mohsen1/json-formatter
                name: 'jsonFormatter',
                files: [
                    bowerRoot + '/json-formatter/dist/json-formatter.js',
                    bowerRoot + '/json-formatter/dist/json-formatter.css'
                ]
            },
            {
                // @desc Angular directive for slick jquery carousel.
                // @see https://github.com/DickSwart/ds6-scroll-class
                name: 'ds6-scroll-class',
                files: [
                    bowerRoot + '/ds6-scroll-class/dist/ds6-scroll-class.min.js'
                ]
            }
        ]
    };

    angular
        .module('yvApp.core')
        .constant('appConfig', appConfig)
        .constant('apiHost', apiHost)
        .constant('apiEndPoint', apiEndPoint)
        .constant('jsRequireDependencies', jsRequireDependencies)
        .constant('moment', moment)
        .constant('enableLogging', enableLogging);
})();

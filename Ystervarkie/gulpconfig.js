(function () {
    'use strict';

    var fs = require('fs'),
        mbf = require('main-bower-files'),
        _ = require('lodash'),
        filter = require('gulp-filter'); // Filter files in a vinyl stream (https://www.npmjs.com/package/gulp-filter)

    var bowerAppGroupName = 'app';

    module.exports = function () {

        var baseDir = {
            web: './wwwroot',
            app: './App',
            bower: getDirectoryFromBowerRc()
        }

        var config = {
            // Filenames used for JS and CSS concatinated files.
            filename: {
                app: 'app',
                libs:'vendor'
            },
            index: {
                in: baseDir.app + '/index.cshtml',
                out: './Views/Shared',
                appInjectOptions: {
                    name: 'app',
                    ignorePath: 'App',
                    addPrefix: '~',
                    addRootSlash: false
                },
                vendorInjectOptions: {
                    name: 'vendor',
                    ignorePath: 'bower_components',
                    addPrefix: '~',
                    addRootSlash: false
                }
            },
            html: {
                in: baseDir.app + '/**/*.html',
                out: 'templates.js',
                templateCacheOpts: {
                    module: 'yvApp.core',
                    root: 'app/',
                    standalone: false
                }
            },
            sass: {
                app: {
                    in: baseDir.app + '/sass',
                    inject: [baseDir.app + '/sass/partials/**/*.scss'],
                    injectIgnorePath: [baseDir.app + '/sass/partials'],
                },
                vendor: {
                    in: baseDir.app + '/sass',
                    includePaths: [
                        baseDir.bower + '/bootstrap-sass-official/assets/stylesheets',
                        baseDir.bower + '/fontawesome/scss',
                        baseDir.bower + '/toastr'
                    ],
                },                
                out: baseDir.web + '/css'
            },
            js: {
                in: baseDir.app + '/**/*.js',
                out: baseDir.web + '/js'
            },
            fonts: {
                in: [
                    baseDir.app + '/fonts/*.{eot,otf,svg,ttf,woff,woff2}',
                    baseDir.bower + '/fontawesome/fonts/*.{eot,otf,svg,ttf,woff,woff2}',
                    baseDir.bower + '/bootstrap-sass-official/assets/fonts/bootstrap/*.{eot,otf,svg,ttf,woff,woff2}'
                ],
                out: baseDir.web + '/fonts'
            },
            libs: {
                main: {
                    getfiles: function (options, isMinFiles) {
                        var defaultOptions = {
                            "overrides": {
                                "toastr": {
                                    "main": ["toastr.js"]
                                },
                                "a0-angular-storage": {
                                    "main": ["dist/angular-storage.min.js"]
                                }
                            }
                        };
                        var opts = (options) ? _.merge(options, defaultOptions) : defaultOptions
                        return getBowerFiles(opts, isMinFiles, false);
                    }
                },
                lazy: {
                    in: './bower.json',
                    out: baseDir.web + '/libs',
                    opt: {
                        checkExistence: 'true',
                        group: '!' + bowerAppGroupName,
                    }
                }
            },
            filters: {
                svg: filter('**/*.svg', { restore: true }),
                js: filter('**/*.js', { restore: true }),
                css: filter('**/*.css', { restore: true }),
                scss: filter('**/*.scss', { restore: true }),
                fonts: filter('**/*.{eot,otf,svg,ttf,woff,woff2}', { restore: true }),
                html: filter('**/*.html', { restore: true })
            }
        }

        // Add baseDir to config
        config.baseDir = baseDir;

        return config;
    }

    /**
     * Detect .bowerrc file and read directory from file
     *
     * @returns {string} found directory or default path
     */
    function getDirectoryFromBowerRc() {
        var DEFAULT_BOWER_DIR = './bower_components';
        var bowerrc = './.bowerrc';

        if (!fs.existsSync(bowerrc)) {
            return DEFAULT_BOWER_DIR;
        }

        var bower_config = {};
        try {
            bower_config = JSON.parse(fs.readFileSync(bowerrc));
        } catch (err) {
            return DEFAULT_BOWER_DIR;
        }

        return bower_config.directory || DEFAULT_BOWER_DIR;
    }

    /**
     * Check if a file exist
     * @param  {String} fullPath - Full path
     * @return {Boolean}
     */
    function checkFileExist(filePath) {
        var exists;
        try {
            fs.statSync(filePath);
            exists = true;
        } catch (e) {
            exists = false;
        }
        return exists;
    }

    function getBowerFiles(options, isMinFiles, isLazyFiles) {
        
        var defaultOptions = {
            checkExistence: 'true',
            group: bowerAppGroupName
        }

        if (isLazyFiles) {
            defaultOptions.group = '!' + bowerAppGroupName;
        }

        var opts = (options) ? _.merge(options, defaultOptions) : defaultOptions

        var bf = mbf(opts);
        if (isMinFiles) {
            bf = bf.map(function (originalPath) {
                var newPath = originalPath.replace(/.([^.]+)$/g, '.min.$1');
                return checkFileExist(newPath) ? newPath : originalPath;
            });
        }
        return bf
    }
})();
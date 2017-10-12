/// <binding Clean='clean' BeforeBuild='build' />
// The above line of code enables Visual Studio to automatically start Gulp tasks at certain key moments. The 'clean'
// task is run on solution clean, the 'build' task is run on solution build and the 'watch' task is run on opening the
// solution. You can also edit the above using the Task Runner Explorer window in Visual Studio
// (See http://docs.asp.net/en/latest/client-side/using-gulp.html)

var gulp = require('gulp'),
    fs = require('fs'),
    sass = require('gulp-sass'),
    autoprefix = require('gulp-autoprefixer'),
    notify = require("gulp-notify"),
    gutil = require('gulp-util'),
    debug = require('gulp-debug'),
    inject = require('gulp-inject'),
    clean = require('gulp-clean'),
    rename = require("gulp-rename"),
    gulpMainBowerFiles = require('gulp-main-bower-files'),
    eslint = require('gulp-eslint'),                        // A gulp plugin for processing files with ESLint (https://www.npmjs.com/package/gulp-eslint)
    gulpSequence = require('gulp-sequence'),                // Run a series of gulp tasks in order. (https://www.npmjs.com/package/gulp-sequence)
    sourcemaps = require('gulp-sourcemaps'),                // Source map support for Gulp.js (https://www.npmjs.com/package/gulp-sourcemaps)
    cleanCSS = require('gulp-clean-css'),                   // Minify CSS, using clean-css (https://github.com/scniro/gulp-clean-css)
    uglify = require('gulp-uglify'),                        // Minify files with UglifyJS. (https://www.npmjs.com/package/gulp-uglify)
    htmlmin = require('gulp-htmlmin'),                      // gulp plugin to minify HTML. (https://www.npmjs.com/package/gulp-htmlmin && http://blog.codesupport.info/gulp-minify-html/)
    concat = require('gulp-concat'),                        // Concatenate files (https://www.npmjs.com/package/gulp-concat/)
    ngAnnotate = require('gulp-ng-annotate'),               // Add angularJS dependency injection annotations (https://www.npmjs.com/package/gulp-ng-annotate)
    angularFilesort = require('gulp-angular-filesort'),     // Automatically sort AngularJS app files depending on module definitions and usage (https://www.npmjs.com/package/gulp-filter)
    config = require('./gulpConfig')();

var filters = config.filters;

gulp.task('default', function () {
    // place code for your default task here
});

// --------------------------------------------------------------------------
// Build Tasks
// --------------------------------------------------------------------------

gulp.task('publish', gulpSequence(['min', 'copy']))
gulp.task('build', gulpSequence(['style', 'copy'], 'inject:index'))

// --------------------------------------------------------------------------
// Inject Tasks
// --------------------------------------------------------------------------

gulp.task('inject:index', ['clean:index'], function () {

    var appStream = gulp.src(config.js.in)
        .pipe(angularFilesort());

    var bowerStream = gulp.src(config.libs.main.getfiles({ filter: '**/*.js' }, true))

    return gulp.src(config.index.in)
        .pipe(inject(appStream, config.index.appInjectOptions))
        .pipe(inject(bowerStream, config.index.vendorInjectOptions))
        .pipe(rename("_Layout.cshtml"))
        .pipe(gulp.dest(config.index.out));
});

// --------------------------------------------------------------------------
// Style Tasks
// --------------------------------------------------------------------------
gulp.task('style', ['style:app', 'style:libs']);

/**
 * Inject sass files and compile sass to css
 * @return {Stream}
 */
gulp.task('style:app', ['clean:style:app'], function () {
    var sassOpts = {
        // outputStyle Values: nested, expanded, compact, compressed
        outputStyle: 'nested',
    };

    // It's not necessary to read the files (will speed up things), we're only after their paths:
    var injectSources = gulp.src(config.sass.app.inject, { read: false });

    return gulp.src(config.sass.app.in + '\\' + config.filename.app + '.scss')
        .pipe(inject(injectSources, { relative: true }))
        .pipe(sass(sassOpts).on('error', sass.logError))
        .pipe(gulp.dest(config.sass.out));
});

/**
 * Inject sass files and compile sass to css
 * @return {Stream}
 */
gulp.task('style:libs', ['clean:style:libs'], function () {
    var sassOpts = {
        // outputStyle Values: nested, expanded, compact, compressed
        outputStyle: 'nested',
        includePaths: config.sass.vendor.includePaths
    };

    var transformFilepath = function (filepath, file) {
        if (filepath.endsWith('.css')) {
            var newFilePath = filepath.substring(0, filepath.length - 4);
            return '@import "' + newFilePath + '";';
        }

        // Use the default transform as fall-back:
        return inject.transform.apply(inject.transform, arguments);
    };

    var injectOptions = {
        transform: transformFilepath,
        relative: true
    };

    // It's not necessary to read the files (will speed up things), we're only after their paths:
    var injectSources = gulp.src(config.libs.main.getfiles({ filter: '**/*.css' }, false), { read: false });


    return gulp.src(config.sass.vendor.in + '\\' + config.filename.libs + '.scss')
        .pipe(inject(injectSources, injectOptions))
        .pipe(sass(sassOpts).on('error', sass.logError))
        .pipe(gulp.dest(config.sass.out));
});

// --------------------------------------------------------------------------
// Copy Tasks
// --------------------------------------------------------------------------
/**
 * Copy All
 * @return {Stream}
 */
gulp.task('copy', ['copy:fonts', 'copy:lazylibs']);

/**
 * Copy all font files to webroot
 * @return {Stream}
 */
gulp.task('copy:fonts', ['clean:fonts'], function () {
    return gulp.src(config.fonts.in)
        //.pipe(debug({ title: 'Fonts:' }))
        .pipe(gulp.dest(config.fonts.out));
});

/**
 * Copy all lib files to webroot
 * @return {Stream}
 */
gulp.task('copy:lazylibs', ['clean:lazylibs'], function () {
    return gulp.src(config.libs.lazy.in)
        .pipe(gulpMainBowerFiles(config.libs.lazy.opt))
        .pipe(gulp.dest(config.libs.lazy.out));
});

// --------------------------------------------------------------------------
// Minify Tasks
// --------------------------------------------------------------------------
gulp.task('min', ['min:js', 'min:style']);
gulp.task('min:style', ['min:style:libs', 'min:style:app']);
gulp.task('min:js', ['min:js:libs', 'min:js:app']);

/**
 * Concatenate minify bower files that is part of the 'bowerAppGroupName'
 * @param  {Function} done - callback when complete
 */
gulp.task('min:js:libs', ['clean:js:libs'], function () {
    return gulp.src(config.libs.main.getfiles({ filter: '**/*.js' }, true))
        .pipe(concat(config.filename.libs + '.min.js'))
        .pipe(gulp.dest(config.libs.main.Js.out));

});

gulp.task('min:js:app', ['clean:js:app'], function () {

    var appJsGlop = eslintScripts(config.js.in, {});
    return appJsGlop
        .pipe(angularFilesort())
        .pipe(concat(config.filename.app + '.js'))
        .pipe(ngAnnotate())
        .pipe(gulp.dest(config.js.out))
        .pipe(sourcemaps.init())
        .pipe(uglify())
        .pipe(sourcemaps.write())
        .pipe(rename({ suffix: '.min' }))
        .pipe(gulp.dest(config.js.out));
});

/**
 * Concatenate minify bower files that is part of the 'bowerAppGroupName'
 * @param  {Function} done - callback when complete
 */
gulp.task('min:style:libs', ['style:libs'], function () {

    return gulp.src(config.sass.out + '\\' + config.filename.libs + '.css')
        .pipe(sourcemaps.init())
        .pipe(cleanCSS())
        .pipe(sourcemaps.write())
        .pipe(rename({ suffix: '.min' }))
        .pipe(gulp.dest(config.libs.main.Css.out));
});

/**
 * Concatenate minify bower files that is part of the 'bowerAppGroupName'
 * @param  {Function} done - callback when complete
 */
gulp.task('min:style:app', ['style:app'], function () {

    // move css files (min)
    return gulp.src(config.sass.out + '\\' + config.filename.app + '.css')
        .pipe(sourcemaps.init())
        .pipe(cleanCSS())
        .pipe(sourcemaps.write())
        .pipe(rename({ suffix: '.min' }))
        .pipe(gulp.dest(config.sass.out));
});

// --------------------------------------------------------------------------
// Clean Tasks
// --------------------------------------------------------------------------

/**
 * Clean All
 * @return {Stream}
 */
gulp.task('clean', ['clean:style', 'clean:js', 'clean:index', 'clean:fonts', 'clean:lazylibs']);
gulp.task('clean:style', ['clean:style:app', 'clean:style:libs']);
gulp.task('clean:js', ['clean:js:app', 'clean:js:libs']);

/**
 * Remove app css from the web directory
 * @return {Stream}
 */
gulp.task('clean:style:app', function () {
    return gulp.src(config.sass.out + '\\' + config.filename.app + '.css', { read: false })
        .pipe(clean());
});

/**
 * Remove libs css from the web directory
 * @return {Stream}
 */
gulp.task('clean:style:libs', function () {
    return gulp.src(config.sass.out + '\\' + config.filename.libs + '.css', { read: false })
        .pipe(clean());
});

/**
 * Remove css from the web directory
 * @return {Stream}
 */
gulp.task('clean:index', function () {
    return gulp.src(config.index.out + '/_Layout.cshtml', { read: false })
        .pipe(clean());
});

/**
 * Remove fonts from the web directory
 * @return {Stream}
 */
gulp.task('clean:fonts', function () {
    return gulp.src(config.fonts.out, { read: false })
        .pipe(clean());
});

/**
 * Remove css from the web directory
 * @return {Stream}
 */
gulp.task('clean:lazylibs', function () {
    return gulp.src(config.libs.lazy.out, { read: false })
        .pipe(clean());
});


/**
 * Remove js from the web directory
 * @return {Stream}
 */
gulp.task('clean:js:app', function () { return cleanJs(config.filename.app); });
gulp.task('clean:js:libs', function () { return cleanJs(config.filename.libs); });

function cleanJs(filename) {
    var jsGlob = [
        config.js.out + '/' + filename + '.js',
        config.js.out + '/' + filename + '.min.js'
    ];
    return gulp.src(jsGlob, { read: false })
        //.pipe(debug({ title: 'clean:js:libs:' }))
        .pipe(clean());
}

// --------------------------------------------------------------------------
// Private Methods
// --------------------------------------------------------------------------
function eslintScripts(source, srcOptions) {
    var angularPlugin = require('eslint-plugin-angular');

    return gulp.src(source, srcOptions)
        .pipe(eslint())
        .pipe(eslint.format());
};
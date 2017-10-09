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

gulp.task('build', ['sass', 'copy', 'clean:index']);

// --------------------------------------------------------------------------
// Inject Tasks
// --------------------------------------------------------------------------

gulp.task('inject:index', ['clean:index'], function () {

    var appGlob = [].concat(config.js.in);
    var appStream = gulp.src(appGlob)
        // Sort Js files
        .pipe(filters.js)
        .pipe(angularFilesort())
        .pipe(filters.js.restore);

    var bowerStream = gulp.src(config.libs.main.getfiles({},false));

    return gulp.src(config.index.in)
        .pipe(inject(appStream, config.index.appInjectOptions))
        .pipe(inject(bowerStream, config.index.vendorInjectOptions))
        .pipe(rename("_Layout.cshtml"))
        .pipe(gulp.dest(config.index.out));
});

// --------------------------------------------------------------------------
// Style Tasks
// --------------------------------------------------------------------------

/**
 * Inject sass files and compile sass to css
 * @return {Stream}
 */
gulp.task('sass', ['clean:css'], function () {
    var sassOpts = {
        // outputStyle Values: nested, expanded, compact, compressed
        outputStyle: 'nested',
        includePaths: config.sass.includePaths
    };

    // It's not necessary to read the files (will speed up things), we're only after their paths:
    var injectSources = gulp.src(config.sass.inject, { read: false });

    return gulp.src(config.sass.in)
        .pipe(inject(injectSources, { relative: true }))
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
gulp.task('copy', ['copy:fonts']);

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
gulp.task('copy:libs', ['clean:libs'], function () {
    return gulp.src(config.libs.lazy.in)
        .pipe(gulpMainBowerFiles(config.libs.lazy.opt))
        .pipe(gulp.dest(config.libs.lazy.out));
});

// --------------------------------------------------------------------------
// Minify Tasks
// --------------------------------------------------------------------------
gulp.task('min:bower', ['min:bower:js', 'min:bower:css']);

/**
 * Concatenate minify bower files that is part of the 'bowerAppGroupName'
 * @param  {Function} done - callback when complete
 */
gulp.task('min:bower:js', function () {

    // move JS files (min)
    return gulp.src(config.libs.main.getfiles({ filter: '**/*.js' }, true))
        .pipe(concat(config.libs.main.Js.minFileName))
        .pipe(gulp.dest(config.libs.main.Js.out));

});

/**
 * Concatenate minify bower files that is part of the 'bowerAppGroupName'
 * @param  {Function} done - callback when complete
 */
gulp.task('min:bower:css', ['sass'], function () {

    var cssGlob = [].concat(
        config.sass.out + '/vendor.css',
        config.libs.main.getfiles({ filter: '**/*.css' }, true)
    );

    // move JS files (min)
    return gulp.src(cssGlob)
        .pipe(concat(config.libs.main.Css.minFileName))
        .pipe(sourcemaps.init())
        .pipe(cleanCSS())
        .pipe(sourcemaps.write())
        .pipe(gulp.dest(config.libs.main.Css.out));
});


// --------------------------------------------------------------------------
// Clean Tasks
// --------------------------------------------------------------------------

/**
 * Clean All
 * @return {Stream}
 */
gulp.task('clean', ['clean:css', 'clean:index', 'clean:fonts', 'clean:libs']);

/**
 * Remove css from the web directory
 * @return {Stream}
 */
gulp.task('clean:css', function () {
    return gulp.src(config.sass.out, { read: false })
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
gulp.task('clean:libs', function () {
    return gulp.src(config.libs.lazy.out, { read: false })
        .pipe(clean());
});


// --------------------------------------------------------------------------
// Private Methods
// --------------------------------------------------------------------------

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
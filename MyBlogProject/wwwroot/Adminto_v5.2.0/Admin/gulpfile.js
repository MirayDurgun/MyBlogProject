"use strict";

var gulp = require("gulp"),
    newer = require("gulp-newer"),
    imagemin = require("gulp-imagemin"),
    sass = require('gulp-sass')(require('sass')),
    sourcemaps = require("gulp-sourcemaps"),
    del = require('del'),
    autoprefixer = require("gulp-autoprefixer"),
    cleanCSS = require('gulp-clean-css'),
    rename = require("gulp-rename"),
    concat = require("gulp-concat"),
    uglify = require("gulp-uglify"),
    npmdist = require('gulp-npm-dist'),
    browsersync = require("browser-sync"),
    fileinclude = require('gulp-file-include'),
    rtlcss = require('gulp-rtlcss'),
    babel = require('gulp-babel'),
    mergeStream =   require('merge-stream');

var folder = {
    src: "src/", // source files
    dist: "dist/", // build files
    dist_assets: "dist/assets/" //build assets files
};


/*
Copy third party libs
*/

function copyAssets() {
    var out = folder.dist_assets + "/libs/";
    return gulp
        .src(npmdist(), { base: './node_modules' })
        .pipe(rename(function (path) {
            path.dirname = path.dirname.replace(/\/dist/, '').replace(/\\dist/, '');
        }))
        .pipe(gulp.dest(out));
}



// cleaning the dist directory
function clean(done) {
    del.sync(folder.dist);
    done();
}

// image processing
function imageMin() {
    var out = folder.dist_assets + "images";
    return gulp
        .src(folder.src + "images/**/*")
        .pipe(newer(out))
        .pipe(imagemin())
        .pipe(gulp.dest(out));
}

// copy fonts from src folder to dist folder
function fonts() {
    var out = folder.dist_assets + "fonts/";

    return gulp.src([folder.src + "fonts/**/*"]).pipe(gulp.dest(out));
}

// copy dummy data in assets
function data() {
    var out = folder.dist_assets + "data/";

    return gulp.src([folder.src + "data/**/*"]).pipe(gulp.dest(out));
}

// copy html files from src folder to dist folder, also copy favicons

// UI App
function html() {
    var out = folder.dist + "";

    return gulp
        .src([
            folder.src + "html/**/*", "!" + folder.src + "html/**/partials/**"
        ])
        .pipe(fileinclude({
            prefix: '@@',
            basepath: '@file',
            indent: true
        }))
        .pipe(gulp.dest(out));
}

// compile & minify sass
function css() {
    return mergeStream(gulp
        .src([folder.src + "/scss/*.scss"])
        .pipe(sourcemaps.init())
        .pipe(sass()) // scss to css
        .pipe(
            autoprefixer({
                overrideBrowserslist: ['> 1%']
            })
        )
        .pipe(gulp.dest(folder.dist_assets + "css/"))
        .pipe(cleanCSS())
        .pipe(
            rename({
                // rename app.css to icons.min.css
                suffix: ".min"
            })
        )
        .pipe(sourcemaps.write("./")) // source maps for icons.min.css
        .pipe(gulp.dest(folder.dist_assets + "css/")),
        
        gulp
            .src([folder.src + "/scss/*.scss"])
            .pipe(sourcemaps.init())
            .pipe(sass()) // scss to css
            .pipe(
                autoprefixer({
                    overrideBrowserslist: ['> 1%']
                })
            )
            .pipe(gulp.dest(folder.dist_assets + "css/"))
            .pipe(rtlcss())
            .pipe(cleanCSS())
            .pipe(
                rename({
                    // rename app.css to icons.min.css
                    suffix: "-rtl.min"
                })
            )
            .pipe(sourcemaps.write("./")) // source maps for icons.min.css
            .pipe(gulp.dest(folder.dist_assets + "css/"))
    );

}

// js
function jsPages() {
    var out = folder.dist_assets + "js/";

    return gulp.src(folder.src + "js/**/*.js")
        .pipe(babel({
            presets: ['@babel/env']
        }))
        .pipe(uglify())
        .on("error", function (err) {
            console.log(err.toString());
        })
        .pipe(gulp.dest(out));
}

function jsTheme() {
    var out = folder.dist_assets + "js/";

    return gulp
        .src([
            folder.src + "js/layout.js",
            folder.src + "js/app.js"
        ])
        .pipe(sourcemaps.init())
        .pipe(concat("app.js"))
        .pipe(gulp.dest(out))
        .pipe(
            rename({
                // rename app.js to app.min.js
                suffix: ".min"
            })
        )
        .pipe(babel({
            presets: ['@babel/env']
        }))
        .pipe(uglify())
        .on("error", function (err) {
            console.log(err.toString());
        })
        .pipe(sourcemaps.write("./"))
        .pipe(gulp.dest(out));
}

// live browser loading
function browserSync(done) {
    browsersync.init({
        startPath: "index.html",
        server: {
            baseDir: folder.dist,
            middleware: [
                function (req, res, next) {
                    req.method = 'GET';
                    next();
                }
            ]
        }
    });
    done();
}

function reloadBrowserSync(done) {
    browsersync.reload();
    done();
}

// watch all changes
function watchFiles() {
    gulp.watch(folder.src + "html/**/*", gulp.series(html, reloadBrowserSync));
    gulp.watch(folder.src + "images/**/*", gulp.series(imageMin, reloadBrowserSync));
    gulp.watch(folder.src + "fonts/**/*", gulp.series(fonts, reloadBrowserSync));
    gulp.watch(folder.src + "scss/**/*", gulp.series(css, reloadBrowserSync));
    gulp.watch(folder.src + "js/**/*", gulp.series(jsPages, jsTheme, reloadBrowserSync));
}

// watch all changes
gulp.task("watch", gulp.parallel(watchFiles, browserSync));

// default task
gulp.task(
    "default",
    gulp.series(
        copyAssets,
        html,
        imageMin,
        fonts,
        data,
        css, jsPages, jsTheme,
        'watch'
    ),
    function (done) { done(); }
);

// build
gulp.task(
    "build",
    gulp.series(clean,
        copyAssets,
        html,
        imageMin,
        fonts,
        data,
        css, jsPages, jsTheme)
);
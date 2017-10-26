/// <binding BeforeBuild='less, build' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

"use strict";

var gulp = require("gulp"),
    fs = require("fs"),
    rename = require("gulp-rename"),
    uglify = require("gulp-uglify"),
    cssmin = require("gulp-cssmin"),
    gulpDebug = require("gulp-debug"),
    less = require("gulp-less");

gulp.task("js-min", function () {
    return gulp.src('./wwwroot/*.js')
        .pipe(uglify())
        .pipe(rename(function (path) {
            path.extname = path.extname.replace('.js', '.min.js');
        }))
        .pipe(gulp.dest('wwwroot/js'));
});

gulp.task("less", function () {
    return gulp.src('Styles/*.less')
        .pipe(less())
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task("less-min", function () {
    return gulp.src('Styles/*.less')
        .pipe(less())
        .pipe(cssmin())
        .pipe(rename(function (path) {
            path.extname = path.extname.replace('.css', '.min.css');
        }))
        .pipe(gulp.dest('wwwroot/css'));
});

/* Copy JS files */
var jsFiles = {
    "bootstrap": [
        "./node_modules/bootstrap/dist/js/*.*"
    ],
    "jquery": [
        "./node_modules/jquery/dist/*.js"
    ],
    "popper.js": [
        "./node_modules/popper.js/dist/umd/*.js"
    ]
};
var jsTasks = Object.keys(jsFiles);
jsTasks.forEach(function (libName) {
    gulp.task('scripts:' + libName, function () {
        return gulp.src(jsFiles[libName])
            .pipe(gulp.dest('./wwwroot/libraries/' + libName + '/js'));
    });
    gulp.task('scripts-min:' + libName, function () {
        return gulp.src(jsFiles[libName])
            .pipe(uglify())
            .pipe(rename(function (path) {
                path.extname = path.extname.replace('.js', '.min.js');
            }))
            .pipe(gulp.dest('./wwwroot/libraries/' + libName + '/js'));
    });
});

/* Copy CSS files */
var cssFiles = {
    "bootstrap": [
        "./node_modules/bootstrap/dist/css/*.*"
    ]
};
var cssTasks = Object.keys(cssFiles);
cssTasks.forEach(function (libName) {
    gulp.task('css:' + libName, function () {
        return gulp.src(cssFiles[libName])
            .pipe(gulp.dest('./wwwroot/libraries/' + libName + '/css'));
    });
});

/* Default task */
gulp.task("build", function () {
    gulp.start('less');
    gulp.start('less-min');
    gulp.start('js-min');
    gulp.start('css:bootstrap');
    gulp.start('scripts:bootstrap');
    gulp.start('scripts:jquery');
    gulp.start('scripts-min:jquery');
    gulp.start('scripts:popper.js');
    gulp.start('scripts-min:popper.js');
});
﻿'use strict';

(function() {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/movies/create', {
                template: '<movie-create></movie-create>'
            });
    }]);

    angular
        .module('app.movie')
        .directive('inputImage', [function () {
            //Ref http://stackoverflow.com/questions/17063000/ng-model-for-input-type-file
            return {
                scope: {
                    inputImage: '=movieCtrl'
                },
                restrict: 'A',
                link: function (scope, element, attrs) {
                    element.bind('change', function (event) {
                        var reader = new FileReader();
                        reader.onload = scope.$parent.movieCtrl.imageIsLoaded;
                        reader.readAsArrayBuffer(event.target.files[0]);
                    });
                }
            }
        }])
        .component('movieCreate', {
            templateUrl: './app/components/movie/views/movie-create.html',
            controllerAs: 'movieCtrl',
            controller: ['$scope', 'movieService', function ($scope, movieService) {
                var self = this;

                this.movie = {};

                this.createMovie = function () {
                    movieService.createMovie(angular.toJson(self.movie));
                }

                this.imageIsLoaded = function (e) {
                    $scope.$apply(function () {
                        self.movie.image = new Uint8Array(e.target.result);
                    });
                }

                this.hasImage = function () {
                    return self.movie.image != undefined;
                }
            }]
        });
})();
'use strict';

(function() {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/movies/create', {
                template: '<movie-create></movie-create>'
            });
    }]);

    angular
        .module('app.movie')
        .component('movieCreate', {
            templateUrl: './app/components/movie/views/movie-create.html',
            controllerAs: 'movieCtrl',
            controller: ['movieService', function (movieService) {
                var self = this;

                this.movie = {
                };

                this.createMovie = function () {
                    movieService.createMovie(angular.toJson(self.movie));
                }
            }]
        });
})();
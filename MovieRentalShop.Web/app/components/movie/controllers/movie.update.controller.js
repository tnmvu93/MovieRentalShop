'use strict';

(function () {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/movies/:movieId/update', {
                template: '<movie-update></movie-update>'
            });
    }]);

    angular
        .module('app.movie')
        .component('movieUpdate', {
            templateUrl: './app/components/movie/views/movie-update.html',
            controllerAs: 'movieCtrl',
            controller: ['$routeParams', 'movieService', function ($routeParams, movieService) {
                var self = this;
                this.movie = {};

                this.movie = movieService.getMovie($routeParams.movieId)
                                .then(function (response) {
                                    self.movie = response.data;
                                });

                this.updateMovie = function () {
                    movieService.updateMovie(self.movie);
                }

                this.hasImage = function () {
                    return self.movie.image != undefined || self.movie.image != null;
                }
            }]
        });
})();
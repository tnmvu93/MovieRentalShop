'use strict';

(function () {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('movies/:movieId/update', {
                template: '<movie-update></movie-update>'
            });
    }]);

    angular
        .module('app.movie')
        .component('movieUpdate', {
            templateUrl: './app/components/movie/views/movie-update.html',
            controllerAs: 'movieCtrl',
            controller: ['$routeParams', 'apiCalling', function ($routeParams, apiCalling) {
                var self = this;
                this.movie = {};

                apiCalling
                    .get('movies/' + $routeParams.movieId)
                    .then(function (response) {
                        self.movie = response.data;
                    });

                this.updateMovie = function () {
                    movieService.createMovie(self.movie);
                }
            }]
        });
})();
'use strict';

(function () {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                template: '<movie-list></movie-list>'
            });
    }]);

    angular
        .module('app.movie')
        .component('movieList', {
            templateUrl: './app/components/movie/views/movie-list.html',
            controller: ['$location', 'apiCalling', 
                function ($location, apiCalling) {
                    var self = this;
                    this.top10 = [];
                    this.active = 0;
                    this.interval = 5000;
                    this.noWrapSlides = false;

                    apiCalling.get('movies/getmovies')
                        .then(function (response, status) {
                            self.top10 = response.data.movies;
                            for (var i = 0; i < self.top10.length; i++) {
                                self.top10[i].index = i;
                            }
                    });

                    this.goToDetail = function (movieId) {
                        $location.path('/movies/' + movieId)
                    }
                }],
            controllerAs: 'movieList'
        });
})();
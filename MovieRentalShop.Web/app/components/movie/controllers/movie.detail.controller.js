'use strict';

(function () {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/movie/:movieId', {
                template: '<movie-detail></movie-detail>'
            });
    }]);

    angular
        .module('app.movie')
        .component('movieDetail', {
            tempateUrl: './app/components/movie/views/movie.detail.template.html',
            controllerAs: 'movieCtrl',
            controller: ['$routeParams', 'apiCalling',
                function MovieDetailController($routeParams, apiCalling) {
                    var self = this;
                    this.movie = {};
                    var params = {
                        movieId: $routeParams.movieId
                    };

                    apiCalling.get('http://localhost:52217/movies/', params).then(function (response) {
                        self.movie = response;
                    });
            }]
        });

   

})();
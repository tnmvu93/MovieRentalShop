'use strict';

(function () {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/movies/:movieId', {
                template: '<movie-detail></movie-detail>'
            });
    }]);

    angular
        .module('app.movie')
        .component('movieDetail', {
            templateUrl: './app/components/movie/views/movie-detail.html',
            controller: ['$routeParams', 'apiCalling',
                function ($routeParams, apiCalling) {
                    var self = this;
                    this.movie = {};

                    apiCalling.get('http://localhost:52217/movies/' + $routeParams.movieId, null, function(response, status) {
                        self.movie = response;
                    });
                }],
            controllerAs: 'movieCtrl'
        });

   

})();
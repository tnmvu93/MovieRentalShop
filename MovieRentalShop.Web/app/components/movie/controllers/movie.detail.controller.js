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
            controllerAs: 'movieCtrl',
            controller: ['$routeParams', 'apiCalling',
                function ($routeParams, apiCalling) {
                    var self = this;
                    this.movie = {};

                    apiCalling
                        .get('movies/' + $routeParams.movieId)
                        .then(function (response) {
                            self.movie = response.data;
                        });
                }]
        });

   

})();
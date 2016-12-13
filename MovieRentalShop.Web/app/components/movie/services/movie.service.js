'use strict';

(function () {
    angular
        .module('app.movie')
        .service('movieService', ['apiCalling'
            , function (apiCalling) {

                this.createMovie = function (movie) {
                    var jsonMovie = angular.toJson(movie);
                    apiCalling.post('movies/create', jsonMovie, {
                        'Content-Type': undefined
                    });
                }

                
        }]);

})();
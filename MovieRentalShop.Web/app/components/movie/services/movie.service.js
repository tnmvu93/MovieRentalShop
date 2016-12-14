'use strict';

(function () {
    angular
        .module('app.movie')
        .service('movieService', ['apiCalling'
            , function (apiCalling) {
                var self = this;

                this.createMovie = function (movie) {
                    var jsonMovie = angular.toJson(movie);
                    apiCalling.post('movies/create', jsonMovie, {
                        'Content-Type': undefined
                    });
                }

                this.updateMovie = function (movie) {
                    var jsonMovie = angular.toJson(movie);
                    var templateApi = 'movies/{0}/update';
                    var api = templateUrl.format(movie.id);

                    apiCalling.post(api, jsonMovie, {
                        'Content-Type': undefined
                    });
                }
                
        }]);

})();
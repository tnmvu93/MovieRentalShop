'use strict';

(function () {
    angular
        .module('app.movie')
        .service('movieService', ['apiCalling'
            , function (apiCalling) {
                var self = this;

                this.getMovie = function (id) {
                    return apiCalling.get('movies/' + id)
                };

                this.createMovie = function (movie) {
                    var jsonMovie = angular.toJson(movie);
                    return apiCalling.post('movies/create', jsonMovie, {
                        'Content-Type': undefined
                    });
                };

                this.updateMovie = function (movie) {
                    var jsonMovie = angular.toJson(movie);
                    var templateApi = 'movies/{0}/update';
                    var api = templateApi.replace('{0}', movie.id);

                    return apiCalling.post(api, jsonMovie, {
                        'Content-Type': undefined
                    });
                };
                
        }]);

})();
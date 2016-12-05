'use strict';

(function () {
    angular
        .module('app.movie')
        .service('movieService', ['apiCalling'
            , function (apiCalling) {

                this.createMovie = function (movie) {
                    apiCalling.post('movies/create', movie);
                }
        }]);

})();
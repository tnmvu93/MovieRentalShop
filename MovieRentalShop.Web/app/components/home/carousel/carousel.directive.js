'use strict';

(function () {
    var app = angular.module('MovieRentalShop');

    app.directive('homeCarousel', function () {
        return {
            restrict: 'E',
            templateUrl: './app/components/home/carousel/carousel.html',
            controller: 'carouselController',
            controllerAs: 'carousel'
        }
    });

    app.controller('carouselController', ['ApiCalling', function (ApiCalling) {
        var self = this;
        this.top10 = [];
        this.active = 0;
        this.interval = 5000;
        this.noWrapSlides = false;

        var result = ApiCalling.get('http://localhost:52217/movies/getmovies', null, function (response, status) {
            self.top10 = response.Movies;
            for (var i = 0; i < self.top10.length; i++) {
                self.top10[i].Id = i;
            }
        });
    }]);

})();
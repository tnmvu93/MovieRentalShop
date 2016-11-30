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
        var result = ApiCalling.get('http://localhost:52217/movies/getmovies', null, function (response, status) {
            self.top10 = response;
        });
    }]);

})();
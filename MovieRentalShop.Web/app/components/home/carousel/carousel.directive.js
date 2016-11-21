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

    app.controller('carouselController', [function () {
        this.top10 = [
            {
                id: 0,
                name: 'Inception (2010)',
                path: './assests/img/film/Inception (2010).jpg'
            }, {
                id: 1,
                name: 'The Dark Knight (2008)',
                path: './assests/img/film/The Dark Knight (2008).jpg'
            }, {
                id: 2,
                name: 'The Lord of the Rings: The Fellowship of the Ring (2001)',
                path: './assests/img/film/The Lord of the Rings The Fellowship of the Ring (2001).jpg'
            }, {
                id: 3,
                name: 'The Lord of the Rings: The Return of the King (2003)',
                path: './assests/img/film/The Lord of the Rings The Return of the King (2003).jpg'
            }, {
                id: 4,
                name: 'The Shawshank Redemption (1994)',
                path: './assests/img/film/The Shawshank Redemption (1994).jpg'
            }
        ];

    }]);

})();
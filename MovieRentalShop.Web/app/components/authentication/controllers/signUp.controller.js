'use strict';

(function () {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/signup', {
            template: '<sign-up></sign-up>'
        });
    }]);

    angular
        .module('app.authentication')
        .component('signUp', {
            templateUrl: './app/components/authentication/views/sign-up.html',
            controllerAs: 'vm',
            controller: [function () {
            }]
        });
})();
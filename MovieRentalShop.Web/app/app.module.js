'use strict';

(function () {
    angular.module('app', [
    'ngAnimate',
    'ngRoute',
    'ui.bootstrap',
    'app.movie'])
    .config(['$locationProvider', '$routeProvider',
        function ($locationProvider, $routeProvider) {
            $locationProvider.hashPrefix('!');

            $routeProvider
                .otherwise({
                    redirectTo: '/'
                });
        }
    ]);

    
})();
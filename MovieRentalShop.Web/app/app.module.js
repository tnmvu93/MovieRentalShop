'use strict';

(function () {
    angular.module('app', [
    'ngAnimate',
    'ngRoute',
    'ui.bootstrap',
    'app.movie'])
    .config(['$locationProvider', '$routeProvider',
        function ($locationProvider, $routeProvider) {
            $routeProvider.otherwise({ redirectTo: '/' });

            // Ref https://scotch.io/tutorials/pretty-urls-in-angularjs-removing-the-hashtag
            // This lets Angular change the routing and URLs of our pages without refreshing the page.
            $locationProvider.html5Mode
        }
    ]);

    
})();
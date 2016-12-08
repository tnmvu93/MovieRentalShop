'use strict';

(function () {
    angular.module('app').config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/signIn', {
            template: '<sign-in></sign-in>'
        });
    }]);

    // Ref http://jasonwatmore.com/post/2014/05/26/angularjs-basic-http-authentication-example
    angular
        .module('app.authentication')
        .component({
            temlateUrl: './app/components/authentication/views/sign-in.html',
            controllerAs: 'vm',
            controller: ['authenticationService', function (authenticationService) {
                var self = this;
                this.user = {};

                this.signIn = function () {
                    authenticationService.signIn(self.user)
                        .then(function (response) {

                        });
                }
            }]
        });
})();
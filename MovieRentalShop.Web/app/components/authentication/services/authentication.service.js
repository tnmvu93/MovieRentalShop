'use strict';

(function () {
    angular
        .module('app.authentication')
        .service('authenticationService', ['apiCalling', function (apiCalling) {


            this.signIn = function (user) {
                return apiCalling.post('login', user);
            };



        }]);
});
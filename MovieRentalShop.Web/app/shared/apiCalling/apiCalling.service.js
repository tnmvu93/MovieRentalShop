'use strict';

(function () {
    var app = angular.module('app');

    var apiServerUrl = 'http://localhost:52217/';

    app.service('apiCalling', ['$http', function ($http) {

        this.get = function (api, params) {
            var result = $http.get(apiServerUrl + api, {
                withCredentials: true,
                params: params
            })
            return result;
        }

        this.post = function (api, data) {
            var result = $http.post(apiServerUrl + api, data, {
                withCredentials: true,
                'Content-Type': 'application/json'
            })
            return result;
        }
    }]);

})();
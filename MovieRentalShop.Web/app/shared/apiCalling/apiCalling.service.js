'use strict';

(function () {
    var app = angular.module('app');

    var apiServerUrl = 'http://localhost:52217/';

    app.service('apiCalling', ['$http', function ($http) {

        this.get = function (api, params, success, error) {
            var result = $http.get(apiServerUrl + api, {
                withCredentials: true,
                params: params
            })
            .success(function (response, status) {
                if (success && typeof(success) === 'function') {
                    success(response, status);
                }
            })
            .error(function () {
                if (error && typeof (error) === 'function') {
                    error();
                } else {
                    console.log('GET. Something was wrong!!!');
                }
            });
            return result;
        }

        this.post = function (api, data, success, error) {
            var result = $http.post(apiServerUrl + api, data, {
                withCredentials: true,
                'Content-Type': 'application/json'
            })
            .success(function (response, status) {
                if (success && typeof (success) === 'function') {
                    success(response, status);
                }
            })
            .error(function (response) {
                if (error && typeof (error) === 'function') {
                    error(response);
                } else {
                    console.log('POST. Something was wrong!!!\n' + response);
                }
            });
            return result;
        }
    }]);

})();
'use strict';

(function () {
    var app = angular.module('app');

    app.service('apiCalling', ['$http', function ($http) {

        this.get = function (api, params, success, error) {
            var result = $http.get(api, {
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
            var result = $http.post(api, data, {
                withCredentials: true
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
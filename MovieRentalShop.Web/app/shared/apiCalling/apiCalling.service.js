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

        this.post = function (api, data, header) {
            var defaultHeader = {
                withCredentials: true,
                'Content-Type': 'application/json'
            };

            header = angular.extend({}, defaultHeader, header);

            var result = $http.post(apiServerUrl + api, data, header);
            return result;
        }
    }]);

})();
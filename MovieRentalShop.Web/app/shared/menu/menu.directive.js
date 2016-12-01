'use strict';

(function () {
    var app = angular.module('app');

    app.directive('appMenu', function () {
        return {
            restrict: 'E',
            templateUrl: './app/shared/menu/menu.html',
            controller: function () {
                this.isNavCollapsed = true;
            },
            controllerAs: 'menu'
        };
    });
})();
'use strict';

(function () {
	var app = angular.module('app');

	app.directive('appFooter', function () {
		return {
			restrict: 'E',
			templateUrl: './app/shared/footer/footer.html'
		};
	});
})();
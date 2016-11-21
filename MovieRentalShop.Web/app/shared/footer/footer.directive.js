'use strict';

(function () {
	var app = angular.module('MovieRentalShop');

	app.directive('appFooter', function () {
		return {
			restrict: 'E',
			templateUrl: './app/shared/footer/footer.html'
		};
	});
})();
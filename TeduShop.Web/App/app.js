/// <reference path="components/Home/HomeController.js" />
/// <reference path="~/Assets/Admin/libs/angular/angular.js" />
//'use strict';
/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('teduShop',
        ['teduShop.products',
         'teduShop.product_categories',
         'teduShop.Common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('Home', {
                url: "/Admin",
                templateUrl: "/App/components/Home/HomeView.html",
                controller: "HomeController"
            });
        $urlRouterProvider.otherwise('/Admin');
    }
})();
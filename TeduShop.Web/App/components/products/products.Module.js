/// <reference path="~/Assets/Admin/libs/angular/angular.js" />

(function () {
    angular.module('teduShop.products', ['teduShop.products','teduShop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl:  "/app/components/products/ProductListView.html",
            controller: "ProductListController"
        }).state('product_add', {
            url: "/product_add",
            templateUrl: "/app/components/products/ProductAddView.html",
            controller:"ProductAddController"
        });
        
    }
})();
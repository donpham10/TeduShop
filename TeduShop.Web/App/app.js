/// <reference path="components/Home/HomeController.js" />
/// <reference path="~/Assets/Admin/libs/angular/angular.js" />

(function(){
    angular.module('teduShop', ['teduShop.products', 'teduShop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('Home', {
            url: "/Admin",

            templateUrl: "/App/components/Home/HomeView.html",
            controller:"HomeController"
        });
        $urlRouterProvider.otherwise('/Admin');
    }
})();
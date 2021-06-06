(function () {
    angular.module('teduShop.product_categories', ['teduShop.product_categories', 'teduShop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/productCategoryListView.html",
            controller: "producCategorytListController"
        });
    }
})();
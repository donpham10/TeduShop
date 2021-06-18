(function () {
    angular.module('teduShop.product_categories', ['teduShop.product_categories', 'teduShop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/productCategoryListView.html",
            controller: "producCategorytListController"
        }).state('add_product_categories', {
            url: "/add_product_categories",
            templateUrl: "/app/components/product_categories/productCategoriesAddView.html",
            controller: "productCategoriesAddController"
        }).state('edit_product_categories', {
            url: "/edit_product_categories/:id",
            templateUrl: "/app/components/product_categories/productCatelogyEditView.html",
            controller: "productCategoryEditController"
        });
    }
})();
(function (app) {
    app.controller('producCategorytListController', producCategorytListController);
    producCategorytListController.$inject = ['$scope', 'apiService']

    function producCategorytListController($scope, apiService) {
        $scope.productCategories = [];
        $scope.getProductCategories = getProductCategories;
        function getProductCategories() {
            apiService.get('/Api/ProductCategory/getall', null,
                function (result) {
                    $scope.productCategories = result.data;
                }, function () {
                    console.log('Load productcatelogies fail');
            });
        }
        $scope.getProductCategories();
    }
})(angular.module('teduShop.product_categories'));

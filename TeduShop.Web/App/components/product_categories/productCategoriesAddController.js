(function (app) {
    app.controller('productCategoriesAddController', productCategoriesAddController);
    productCategoriesAddController.$inject = ['$scope', 'apiService', 'notificationService','$state']

    function productCategoriesAddController($scope, apiService, notificationService, $state) {
        $scope.productCategory = {
            CreatedDate: new Date(),
            Status:true
        }
        $scope.parentCategories = [];
        $scope.AddProductCategory = AddProductCategory;

        function AddProductCategory()
        {
            apiService.post('Api/ProductCategory/create', $scope.productCategory, function (result) {
                notificationService.displaySuccess(result.data.Name + ' đã được thêm mới!');
                $state.go('product_categories');
            }, function (error) {
                notificationService.displayError('Thêm mới không thành Công.');
            });
        }

        function loadParentCategory() {
            apiService.get('Api/ProductCategory/getallParentId', null, function (result) {
                $scope.parentCategories = result.data;
            }, function () {
                Console.log('cannot get list parent');
            });
        }
        loadParentCategory();
    }
})(angular.module('teduShop.product_categories'));

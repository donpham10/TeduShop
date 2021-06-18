(function (app) {
    app.controller('productCategoryEditController', productCategoryEditController);
    productCategoryEditController.$inject = ['$scope', 'apiService', 'notificationService', '$state','$stateParams','commonService']

    function productCategoryEditController($scope, apiService, notificationService, $state,$stateParams,commonService) {
        $scope.productCategory = {
            CreatedDate: new Date(),
            Status: true
        }
        $scope.parentCategories = [];
        $scope.UpdateProductCategory = UpdateProductCategory;

        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.productCategory.Alias =commonService.getSeoTitle( $scope.productCategory.Name);
            
        }
        function loadProductCategoryDetail()
        {
            apiService.get('Api/ProductCategory/getbyid/' + $stateParams.id, null, function (result) {
                $scope.productCategory = result.data;
            }, function (error) {
                notificationService.displayError(error.data);
            });
        }
        function UpdateProductCategory() {
            apiService.put('Api/ProductCategory/update', $scope.productCategory, function (result) {
                notificationService.displaySuccess(result.data.Name + ' đã được thay đổi!');
                $state.go('product_categories');
            }, function (error) {
                notificationService.displayError('Thay đổi  không thành Công.');
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
        loadProductCategoryDetail();
    }
})(angular.module('teduShop.product_categories'));

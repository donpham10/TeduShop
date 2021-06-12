(function (app) {
    app.controller('producCategorytListController', producCategorytListController);
    producCategorytListController.$inject = ['$scope', 'apiService', 'notificationService']

    function producCategorytListController($scope, apiService, notificationService) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.getProductCategories = getProductCategories;
        $scope.filter = '';
        $scope.search = search;
        function search() {
           getProductCategories();
        }
        function getProductCategories(filter,page) {
            page = page || 0;
            var config = {
                params: {
                    filter: $scope.filter,
                    page: page,
                    pageSize: 20
                }
            };
            apiService.get('/Api/ProductCategory/getall', config,
                function (result) {
                    if (result.data.TotalCount == 0)
                    {
                        notificationService.displayWarning('Không có bản ghi nào được tìm thấy!!!');
                    } 
                    $scope.productCategories = result.data.Items;
                    $scope.page = result.data.Page;
                    $scope.pagesCount = result.data.TotalPages;
                    $scope.totalCount = result.data.TotalCount;
                }, function () {
                    console.log('Load productcatelogies fail');
            });
        }
        $scope.getProductCategories();
    }
})(angular.module('teduShop.product_categories'));

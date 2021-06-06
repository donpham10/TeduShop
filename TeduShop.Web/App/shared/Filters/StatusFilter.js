(function (app) {
    app.filter('StatusFilter', function () {
        return function (input) {
            if (input == true)
                return 'Kích Hoạt';
            return "Khóa"; 
        }
    });
})(angular.module('teduShop.Common'))
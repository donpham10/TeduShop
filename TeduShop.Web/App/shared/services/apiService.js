/// <reference path="C:\Users\donph\Source\Repos\donpham10\TeduShop\TeduShop.Web\Assets/Admin/libs/angular/angular.js" />
/// <reference path="/Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.factory('apiService', apiService);

    apiService.$inject = ['$http'];

    function apiService($http) {
        return {
            get: get
        }
        function get(url, params, success, failure) {
            $http.get(url, params).then(function (result) {
                success(result);
            }, function (error) {
                failure(error);
            });
        }
    }
})(angular.module('teduShop.Common'));
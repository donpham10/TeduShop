/// <reference path="C:\Users\donph\Source\Repos\donpham10\TeduShop\TeduShop.Web\Assets/Admin/libs/angular/angular.js" />
/// <reference path="/Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.factory('apiService', apiService);

    apiService.$inject = ['$http','notificationService'];

    function apiService($http, notificationService) {
        return {
            get: get,
            post: post,
            put:put
        }
        function post(url, data, success, failure) {
            $http.post(url, data).then(function (result) {
                success(result);
            }, function (error) {
                if (error.status == '401')
                {
                    notificationService.displayError('Authenticate is requied')
                }
                failure(error);
            });
        }

         function put(url, data, success, failure) {
            $http.put(url, data).then(function (result) {
                success(result);
            }, function (error) {
                if (error.status == '401')
                {
                    notificationService.displayError('Authenticate is requied')
                }
                failure(error);
            });
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
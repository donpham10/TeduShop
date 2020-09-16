/// <reference path="../plugins/angular/angular.js" />

var app = angular.module("myApp", []);

app.controller("myController", myController);
myController.$inject = ['$scope'];
function myController($scope) {
    $scope.firstName = "John";
    $scope.lastName = "Doe";
}


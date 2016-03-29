
// module
var personApp = angular.module('personApp', []);

// controller
personApp.controller('personController', ['$scope', function ($scope) {
    $scope.name = 'Mary Jane';
}]);

personApp.controller('personController2', function ($scope) {
    $scope.firstName = 'Mary';
    $scope.lastName = 'Jane';
});
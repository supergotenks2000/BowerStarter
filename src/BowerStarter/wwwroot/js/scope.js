
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

personApp.controller('personController3', function ($scope, personFactory) {
    $scope.name = personFactory.getName();
})

// factory
personApp.factory('personFactory', function () {
    function getName() {
        return 'Mary Jane';
    }

    var service = {
        getName: getName
    };

    return service;
})
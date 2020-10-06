var app = angular.module('App');
app.controller('createController', ['$scope','userFactory', '$http', createController])

function createController($scope, userFactory, $http) {
    
    $scope.user = userFactory.getInstance();

    var getConfig =
    {
        method: 'POST',
        url: 'http://localhost:10101/User',
        data:$scope.user
    }
   
    $scope.insert = function () {
        
        $http(getConfig).then(success, fail)    
    }

    function success(response) {
        alert(response.data);
    };
    function fail(response)
    {
        alert(response.data);
    };

}
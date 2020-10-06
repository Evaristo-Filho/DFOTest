var app = angular.module('App');
app.controller('getListController', ['$scope','userFactory', '$http', getListController])

function getListController($scope, userFactory, $http) {
    $scope.users=null;
    var getConfig =
    {
        method: 'GET'
    }
    $scope.get = function () {
        
        getConfig.url= 'http://localhost:10101/User/';
        $http(getConfig).then(success, fail)    
    }
    $scope.get();
    function success(response) {
      $scope.users= response.data;
    };
    function fail(response)
    {
        alert(response.data);
    };

}
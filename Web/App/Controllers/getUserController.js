var app = angular.module('App');
app.controller('getUserController', ['$scope','userFactory', '$http', getUserController])

function getUserController($scope, userFactory, $http) {
    
    $scope.user = userFactory.getInstance();
    u = $scope.user;
    var getConfig =
    {
        method: 'GET',
        data:$scope.user
    }
   
    $scope.get = function () {
        
        getConfig.url= 'http://localhost:10101/User/'+$scope.user.Id;
        $http(getConfig).then(success, fail)    
    }

    function success(response) {
        u.Id=response.data.id;
        u.Name=response.data.name;
        u.Address=response.data.address;
        u.Age=response.data.age;
        
    };
    function fail(response)
    {
        alert(response.data);
    };

}
var app = angular.module('App');
app.controller('updateController', ['$scope','userFactory', '$http', updateController])

function updateController($scope, userFactory, $http) {
    
    $scope.user = userFactory.getInstance();

    var getConfig =
    {
        method: 'PUT',
        data:$scope.user
    }
   
    $scope.update = function () {
        
        getConfig.url= 'http://localhost:10101/User/'+$scope.user.Id;
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
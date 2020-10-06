var app = angular.module('App', ['ngRoute']);

app.config(function ($routeProvider, $locationProvider) {
    $routeProvider
         .when('/create', {
             templateUrl: "/App/Partials/create.html",
             controller: 'createController'
         })
        .when('/update', {
        templateUrl: 'App/Partials/update.html',
        controller: 'updateController'
        })
        .when('/getUser', {
        templateUrl: 'App/Partials/getUser.html',
        controller: 'getUserController'
        })
        .when('/getList', {
        templateUrl: 'App/Partials/getList.html',
        controller: 'getListController'
        }),
    
    $locationProvider.html5Mode(true);
});





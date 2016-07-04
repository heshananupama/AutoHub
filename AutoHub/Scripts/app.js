var app = angular.module("AutoHub", ["ngRoute"])
.config(function ($routeProvider) {
    $routeProvider
    .when("/Home", {
        templateUrl: "Templates/Home.html",
        controller: "HomeController"
    })

    .when("/Brands", {
        templateUrl: "Templates/Brands.html",
        controller: "BrandsController"
    })

     .when("/Leyland", {
         templateUrl: "Templates/Home.html",
         controller: "BrandsController"
     })

      .otherwise({ redirectTo: "/Home" })
});

 
   $("#carousel").carousel();
 
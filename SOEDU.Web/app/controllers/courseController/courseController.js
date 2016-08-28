/// <reference path="E:\_Study\_SourceCode\_SourseGithub\HocOnline\SOEDU\SOEDU.Web\Content/Plugins/angular/angular.js" />
(function (app) {
    app.controller('courseController', courseController);
    courseController.$inject = ['apiService', '$scope', 'notificationService'];
    function courseController(apiService, $scope, notificationService) {
        $scope.courses = [];
        function getAllCourse() {
            apiService.get('http://localhost:2146/api/course/getall', null, function (result) {
                $scope.courses = result.data;
            }, function () {
                console.log('Load product failed.');
            });
        }
        getAllCourse();
    }
})(angular.module('myApp'));
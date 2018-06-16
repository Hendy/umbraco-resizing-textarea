(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("ResizeableTextareaController", ResizeableTextareaController);

    ResizeableTextareaController.$inject = ['$scope'];

    function ResizeableTextareaController($scope) {

        $scope.model.value = $scope.model.value || '';

    }

})();

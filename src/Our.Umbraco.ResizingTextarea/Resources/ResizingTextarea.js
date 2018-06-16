(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("ResizingTextareaController", ResizingTextareaController);

    ResizingTextareaController.$inject = ['$scope'];

    function ResizingTextareaController($scope) {

        $scope.model.value = $scope.model.value || '';

    }

})();

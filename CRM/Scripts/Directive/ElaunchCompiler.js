﻿(function () {
    'use strict';
    angular
      .module("CRMApp.Directives")
    .directive('compileTemplate',["$compile","$parse", function ($compile, $parse) {
        return {
            restrict: "A",
            link: function (scope, element, attr) {
                var parsed = $parse(attr.ngBindHtml);
                function getStringValue() { return (parsed(scope) || '').toString(); }

                //Recompile if the template changes
                scope.$watch(getStringValue, function () {
                    $compile(element, null, -9999)(scope);  //The -9999 makes it skip directives so that we do not recompile ourselves
                });
            }
        }
    }])

})()
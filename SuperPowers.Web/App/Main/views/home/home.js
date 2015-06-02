(function() {
    var controllerId = 'app.views.home';

    angular.module('app').controller(controllerId, ['$scope', 'abp.services.app.classify',
        function ($scope, classifyService) {
            var vm = this;
            
            $scope.showContent = function ($fileContent) {
                $scope.content = $fileContent;
                var lines = $scope.content.split(/\n/);
                vm.listSuperPowersPersons = []
                for (var i = 0; i < lines.length; i++) {
                    // only push this line if it contains a non whitespace character.
                    if (/\S/.test(lines[i])) {
                        vm.listSuperPowersPersons.push($.trim(lines[i]));
                    }
                }
            };

            //  Función para enviar el contenido del archivo y clasificarlo
            vm.classifyHeroesAndVillains = function () {
                classifyService.getClassifyHeroesAndVillains({ listHeroesAndVillains: vm.listSuperPowersPersons })
                .success(function (data) {
                    vm.listHeroes = data.listHeroes;
                    vm.listVillains = data.listVillains;
                    abp.notify.success('Se han clasificado correctamente Héroes y Villanos', 'Información');
                })
                .error(function (error) {
                    abp.notify.success(error.message, 'Error');
                });;
            };
        }
    ]);

    angular.module('app').directive('onReadFile', function ($parse) {
        return {
            restrict: 'A',
            scope: false,
            link: function (scope, element, attrs) {
                var fn = $parse(attrs.onReadFile);

                element.on('change', function (onChangeEvent) {
                    var reader = new FileReader();

                    reader.onload = function (onLoadEvent) {
                        scope.$apply(function () {
                            fn(scope, { $fileContent: onLoadEvent.target.result });
                        });
                    };

                    reader.readAsText((onChangeEvent.srcElement || onChangeEvent.target).files[0]);
                });
            }
        };
    });
})();
# Exam .NET 2021

## Structure d'un projet

.sln -> ne pas modifer à la main, fichier de solution \
.csproj -> ficher projet, avec dépendences..

## dotnet cli

[dotnet cli](https://docs.microsoft.com/fr-fr/dotnet/core/tools/)
1. Créer une solution -> dotnet new sln
2. Créer un projet -> dotnet new <template-projet> -o "path" 
3. Ajouter projet à solution -> dotnet sln add "path/*.csproj"
4. Ajouter une projet en ref d'un autre projet -> dotnet add "app/app.csproj" reference "lib/lib.csproj"


## Publier un package sur Nuget

[Doc Microsoft](https://docs.microsoft.com/fr-fr/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)

1. `dotnet pack` dans le .csproj
2. `dotnet nuget push "MyPackage.nupkg" --api-key qz2jga8pl3dvn2akksyquwcs9ygggg4exypy3bhxy6w6x6 --source https://api.nuget.org/v3/index.json`
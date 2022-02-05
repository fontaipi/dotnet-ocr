# Exam .NET 2021

## Structure d'un projet

.sln -> ne pas modifer à la main, fichier de solution
.csproj -> ficher projet, avec dépendences..

## dotnet cli

1. Créer une solution -> dotnet new sln
2. Créer un projet -> dotnet new <template-projet> -o "path" 
3. Ajouter projet à solution -> dotnet sln add "path/*.csproj"
4. Ajouter une projet en ref d'un autre projet -> dotnet add "app/app.csproj" reference "lib/lib.csproj"
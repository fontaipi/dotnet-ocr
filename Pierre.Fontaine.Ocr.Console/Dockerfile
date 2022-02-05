FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pierre.Fontaine.Ocr.Console/Pierre.Fontaine.Ocr.Console.csproj", "Pierre.Fontaine.Ocr.Console/"]
RUN dotnet restore "Pierre.Fontaine.Ocr.Console/Pierre.Fontaine.Ocr.Console.csproj"
COPY . .
WORKDIR "/src/Pierre.Fontaine.Ocr.Console"
RUN dotnet build "Pierre.Fontaine.Ocr.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pierre.Fontaine.Ocr.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pierre.Fontaine.Ocr.Console.dll"]

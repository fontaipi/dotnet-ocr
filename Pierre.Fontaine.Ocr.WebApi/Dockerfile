FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pierre.Fontaine.Ocr.WebApi/Pierre.Fontaine.Ocr.WebApi.csproj", "Pierre.Fontaine.Ocr.WebApi/"]
RUN dotnet restore "Pierre.Fontaine.Ocr.WebApi/Pierre.Fontaine.Ocr.WebApi.csproj"
COPY . .
WORKDIR "/src/Pierre.Fontaine.Ocr.WebApi"
RUN dotnet build "Pierre.Fontaine.Ocr.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pierre.Fontaine.Ocr.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pierre.Fontaine.Ocr.WebApi.dll"]

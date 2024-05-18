FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /src
EXPOSE 80
EXPOSE 443

COPY . .
WORKDIR /src/Pacagroup.Ecommerce.Services.WebApi
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /src/Pacagroup.Ecommerce.Services.WebApi/out ./

ENTRYPOINT ["dotnet", "Pacagroup.Ecommerce.Services.WebApi.dll"]
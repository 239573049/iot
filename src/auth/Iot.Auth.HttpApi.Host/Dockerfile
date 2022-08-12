FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/auth/Iot.Auth.HttpApi.Host/Iot.Auth.HttpApi.Host.csproj", "Iot.Auth.HttpApi.Host/"]
RUN dotnet restore "src/auth/Iot.Auth.HttpApi.Host/Iot.Auth.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/Iot.Auth.HttpApi.Host"
RUN dotnet build "Iot.Auth.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Iot.Auth.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Iot.Auth.HttpApi.Host.dll"]

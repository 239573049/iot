#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/auth/Iot.Auth.HttpApi.Host/Iot.Auth.HttpApi.Host.csproj", "src/auth/Iot.Auth.HttpApi.Host/"]
COPY ["src/Iot.HttpApi/Iot.HttpApi.csproj", "src/Iot.HttpApi/"]
COPY ["src/Iot.Domain.Shared/Iot.Domain.Shared.csproj", "src/Iot.Domain.Shared/"]
COPY ["src/auth/Iot.Auth.Application/Iot.Auth.Application.csproj", "src/auth/Iot.Auth.Application/"]
COPY ["src/modules/Iot.Common.Jwt/Iot.Common.Jwt.csproj", "src/modules/Iot.Common.Jwt/"]
COPY ["src/Iot.Domain/Iot.Domain.csproj", "src/Iot.Domain/"]
COPY ["src/auth/Iot.Auth.Application.Contracts/Iot.Auth.Application.Contracts.csproj", "src/auth/Iot.Auth.Application.Contracts/"]
COPY ["src/Iot.Application.Contracts/Iot.Application.Contracts.csproj", "src/Iot.Application.Contracts/"]
COPY ["src/auth/Iot.Auth.Domain/Iot.Auth.Domain.csproj", "src/auth/Iot.Auth.Domain/"]
COPY ["src/auth/Iot.Auth.Domain.Shared/Iot.Auth.Domain.Shared.csproj", "src/auth/Iot.Auth.Domain.Shared/"]
COPY ["src/auth/Iot.Auth.EntityFrameworkCore/Iot.Auth.EntityFrameworkCore.csproj", "src/auth/Iot.Auth.EntityFrameworkCore/"]
COPY ["src/auth/Iot.Auth.HttpApi/Iot.Auth.HttpApi.csproj", "src/auth/Iot.Auth.HttpApi/"]
RUN dotnet restore "src/auth/Iot.Auth.HttpApi.Host/Iot.Auth.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/auth/Iot.Auth.HttpApi.Host"
RUN dotnet build "Iot.Auth.HttpApi.Host.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Iot.Auth.HttpApi.Host.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Iot.Auth.HttpApi.Host.dll"]
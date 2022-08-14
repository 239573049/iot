#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/admin/Iot.Admin.HttpApi.Host/Iot.Admin.HttpApi.Host.csproj", "src/admin/Iot.Admin.HttpApi.Host/"]
COPY ["src/Iot.Application/Iot.Application.csproj", "src/Iot.Application/"]
COPY ["src/Iot.Domain/Iot.Domain.csproj", "src/Iot.Domain/"]
COPY ["src/Iot.Domain.Shared/Iot.Domain.Shared.csproj", "src/Iot.Domain.Shared/"]
COPY ["src/Iot.Application.Contracts/Iot.Application.Contracts.csproj", "src/Iot.Application.Contracts/"]
COPY ["src/Iot.EntityFrameworkCore/Iot.EntityFrameworkCore.csproj", "src/Iot.EntityFrameworkCore/"]
COPY ["src/Iot.HttpApi/Iot.HttpApi.csproj", "src/Iot.HttpApi/"]
COPY ["src/admin/Iot.Admin.Application/Iot.Admin.Application.csproj", "src/admin/Iot.Admin.Application/"]
COPY ["src/modules/Iot.Common.Jwt/Iot.Common.Jwt.csproj", "src/modules/Iot.Common.Jwt/"]
COPY ["src/admin/Iot.Admin.Application.Contracts/Iot.Admin.Application.Contracts.csproj", "src/admin/Iot.Admin.Application.Contracts/"]
COPY ["src/admin/Iot.Admin.HttpApi/Iot.Admin.HttpApi.csproj", "src/admin/Iot.Admin.HttpApi/"]
RUN dotnet restore "src/admin/Iot.Admin.HttpApi.Host/Iot.Admin.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/admin/Iot.Admin.HttpApi.Host"
RUN dotnet build "Iot.Admin.HttpApi.Host.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Iot.Admin.HttpApi.Host.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Iot.Admin.HttpApi.Host.dll"]
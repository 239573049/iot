## 授权服务

当前服务 负责授权 权限认证 权限控制 权限校验 权限分配 权限管理


Consul 配置

请注入使用docker network网络访问，保证安全

```json
{
  "App": {
    "CorsOrigins": "https://*.Iot.com"
  },
  "ConnectionStrings": {
    "Default": "Server=mssql;Database=Iot;User Id =iot;Password=Aa123456.;"
  },
  "Redis": {
    "Configuration": "redis"
  },
  "TokenOptions": {
    "SecretKey": "x234567g9456789g52",
    "Issuer": "iot.tokengo.top",
    "Audience": "iot.tokengo.top",
    "ExpireMinutes": 1720000
  },
  "RabbitMQ": {
    "Connections": {
      "Default": {
        "HostName": "rabbitmq",
        "Port": "5672",
        "UserName": "iot",
        "Password": "dd666666"
      }
    },
    "EventBus": {
      "ClientName": "iot",
      "ExchangeName": "admin"
    }
  }
}

```
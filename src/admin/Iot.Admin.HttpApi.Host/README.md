## 业务服务

当前服务 负责主要业务
iot日志管理
设备管理
。。。。


Consul 配置

请注入使用docker network网络访问，保证安全

```json
{
  "App": {
    "CorsOrigins": "https://*.Iot.com"
  },
  "TokenOptions": {
    "SecretKey": "x234567g9456789g52",
    "Issuer": "iot.tokengo.top",
    "Audience": "iot.tokengo.top",
    "ExpireMinutes": 1720000
  },
  "ConnectionStrings": {
    "Default": "Server=mssql;Database=Iot;User Id =iot;Password=Aa123456.;"
  },
  "Redis": {
    "Configuration": "redis"
  },
  "StringEncryption": {
    "DefaultPassPhrase": "snh24WXeZI3U8wmJ"
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
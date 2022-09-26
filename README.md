# Iot
[![Build Status](https://drone.tokengo.top:442/api/badges/Simple-china/Iot/status.svg)](https://drone.tokengo.top:442/Simple-china/Iot)

## 🎗️介绍
Token的Iot管理后台服务器

当前项目是iot后台服务器

如果需要查看界面展示请前往 [iot-web](https://gitee.com/Simple-china/iot-web)




## 🛎️项目部署

1. 在运行compose文件的时候请先创建一个docker网络

2. 进入到./stack 中运行docker-compose.yml文件 

3. 创建docker网络可以有效避免容器网络混乱问题

```shell
docker network create token  # 创建一个token的docker网络
```

项目所需依赖都在compose文件中
conf.d/ 是nginx的配置
cert/ 是证书文件夹

```shell
docker-compose up -d # 运行项目的基本依赖中间件
```

根目录的docker-compose文件是Iot后台服务的部署文件

可以自行修改镜像地址

iot-auth 项目是授权和权限管理服务

iot-admin 是基本项目功能服务

部署当前服务之前必须运行以上服务

```shell
docker-compose up -d # 运行项目服务
```



## 💪**技术支持**

技术问题或者项目bug请进群聊讨论：737776595

出现项目bug可以提Issue

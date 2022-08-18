# 生成 Iot 库的迁移文件 （需将 Init 修改为实际的改动名字）

```shell
dotnet ef migrations add init --project ../Iot.EntityFrameworkCore.DbMigrator
```

# 执行  库的最近一次迁移

```shell
dotnet ef database update --project ../Iot.EntityFrameworkCore.DbMigrator
```

# 撤销上次迁移(-f 表示强制)
```shell
dotnet ef migrations remove -f --project ../Iot.EntityFrameworkCore.DbMigrator
```

# 生成本次迁移的幂等SQL脚本（适合生产环境）
# 参考： https://docs.microsoft.com/zh-cn/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli#idempotent-sql-scripts
#dotnet ef migrations script --idempotent --project ../Iot.EntityFrameworkCore.DbMigrator
dotnet ef migrations script ScriptName --project ../Iot.EntityFrameworkCore.DbMigrator
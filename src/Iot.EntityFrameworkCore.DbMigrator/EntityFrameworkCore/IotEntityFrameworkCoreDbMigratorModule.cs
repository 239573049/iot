using Iot.Auth.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Iot.EntityFrameworkCore.DbMigrator.EntityFrameworkCore;

[DependsOn(
    typeof(IotEntityFrameworkCoreModule),
    typeof(IotAuthEntityFrameworkCoreModule))]
public class IotEntityFrameworkCoreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;

        services.AddAbpDbContext<IotDbContext>();
        services.AddAbpDbContext<IotAuthDbContext>();
    }
}
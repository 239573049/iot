using Iot.EntityFrameworkCore;
using Iot.EntityFrameworkCore.DbMigrator.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Iot.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IotEntityFrameworkCoreDbMigratorModule),
    typeof(IotApplicationContractsModule)
    )]
public class IotDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}

using Iot.Auth.Domain;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace Iot.Auth.EntityFrameworkCore.EntityFrameworkCore;

[DependsOn(
    typeof(IotAuthDomainModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule))]
public class IotAuthEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<IotAuthDbContext>(options =>
        {
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options => { options.UseSqlServer(); });
    }
}
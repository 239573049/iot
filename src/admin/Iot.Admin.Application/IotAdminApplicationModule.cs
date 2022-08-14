using Iot.Admin.Application.Contracts;
using Iot.Common.Jwt;
using Volo.Abp.AutoMapper;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.Modularity;

namespace Iot.Admin.Application;

[DependsOn(
    typeof(IotCommonJwtModule),
    typeof(AbpEventBusRabbitMqModule),
    typeof(IotAdminApplicationContractsModule))]
public class IotAdminApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<IotAdminApplicationModule>();
        });
    }
}
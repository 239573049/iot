using Volo.Abp.Modularity;

namespace Iot.Auth.Domain.Shared;

[DependsOn(typeof(IotDomainSharedModule))]
public class IotAuthDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}
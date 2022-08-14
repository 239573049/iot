using Volo.Abp.Modularity;

namespace Iot;

[DependsOn(
    typeof(IotDomainSharedModule)
)]
public class IotDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}

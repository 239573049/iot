using Iot.Auth.Application.Contracts;
using Iot.Localization;
using Localization.Resources.AbpUi;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Iot.Auth.HttpApi;

[DependsOn(
    typeof(IotAuthApplicationContractsModule)
)]
public class IotAuthHttpApiModule : AbpModule
{
    
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }

}
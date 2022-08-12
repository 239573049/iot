using Iot.Localization;
using Localization.Resources.AbpUi;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Iot.Auth.Application.Contracts;

[DependsOn(
    typeof(IotApplicationContractsModule))]
public class IotAuthApplicationContractsModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<IotResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
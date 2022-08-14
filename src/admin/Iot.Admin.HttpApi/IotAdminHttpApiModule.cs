using Iot.Admin.Application.Contracts;
using Localization.Resources.AbpUi;
using Iot.Localization;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace Iot;

[DependsOn(
    typeof(IotAdminApplicationContractsModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
public class IotAdminHttpApiModule : AbpModule
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

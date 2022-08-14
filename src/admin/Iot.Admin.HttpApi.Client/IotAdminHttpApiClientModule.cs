using Iot.Admin.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;

namespace Iot;

[DependsOn(
    typeof(IotApplicationContractsModule),
    typeof(IotAdminApplicationContractsModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class IotAdminHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(IotApplicationContractsModule).Assembly,
            RemoteServiceName
        );
        
        context.Services.AddHttpClientProxies(
            typeof(IotAdminApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options => { options.FileSets.AddEmbedded<IotAdminHttpApiClientModule>(); });
    }
}
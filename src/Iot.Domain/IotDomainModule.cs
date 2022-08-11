using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.AuditLogging;
using Volo.Abp.Emailing;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.SettingManagement;

namespace Iot;

[DependsOn(
    typeof(IotDomainSharedModule),
    typeof(AbpAuditLoggingDomainModule),
    typeof(AbpFeatureManagementDomainModule),
    typeof(AbpSettingManagementDomainModule),
    typeof(AbpEmailingModule)
)]
public class IotDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {

#if DEBUG
        context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
#endif
    }
}

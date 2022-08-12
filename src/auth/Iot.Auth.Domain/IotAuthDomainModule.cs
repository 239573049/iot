using Volo.Abp.Modularity;

namespace Iot.Auth.Domain;

[DependsOn(
    typeof(IotDomainModule))]
public class IotAuthDomainModule : AbpModule
{
    
}
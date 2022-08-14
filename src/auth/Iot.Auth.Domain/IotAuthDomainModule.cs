using Iot.Auth.Domain.Shared;
using Volo.Abp.Modularity;

namespace Iot.Auth.Domain;

[DependsOn(typeof(IotAuthDomainSharedModule))]
public class IotAuthDomainModule : AbpModule
{
    
}
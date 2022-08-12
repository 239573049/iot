using Iot.Auth.Application.Contracts;
using Volo.Abp.Modularity;

namespace Iot.Auth.HttpApi;

[DependsOn(
    typeof(IotAuthApplicationContractsModule)
)]
public class IotAuthHttpApiModule : AbpModule
{
    
}
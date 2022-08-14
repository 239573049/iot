using Iot.Auth.Application.Contracts;
using Iot.Auth.Domain;
using Iot.Common.Jwt;
using Volo.Abp.Modularity;

namespace Iot.Auth.Application;

[DependsOn(typeof(IotAuthApplicationContractsModule),
    typeof(IotCommonJwtModule))]
public class IotAuthApplicationModule : AbpModule
{
}
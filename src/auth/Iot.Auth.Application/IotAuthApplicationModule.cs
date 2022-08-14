using Iot.Auth.Application.Contracts;
using Iot.Auth.Domain;
using Iot.Common.Jwt;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Iot.Auth.Application;

[DependsOn(typeof(IotAuthApplicationContractsModule),
    typeof(AbpAutoMapperModule),
    typeof(IotCommonJwtModule))]
public class IotAuthApplicationModule : AbpModule
{
}
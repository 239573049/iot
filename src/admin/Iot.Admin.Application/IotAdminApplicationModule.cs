using Iot.Admin.Application.Contracts;
using Iot.Common.Jwt;
using Volo.Abp.Modularity;

namespace Iot.Admin.Application;

[DependsOn(
    typeof(IotCommonJwtModule),
    typeof(IotAdminApplicationContractsModule))]
public class IotAdminApplicationModule : AbpModule
{
}
using Iot.Common.Core;
using Volo.Abp.Modularity;

namespace Iot.Admin.Application.Contracts;

[DependsOn(
    typeof(IotApplicationContractsModule),
    typeof(IotCommonCoreModule))]
public class IotAdminApplicationContractsModule : AbpModule
{
}
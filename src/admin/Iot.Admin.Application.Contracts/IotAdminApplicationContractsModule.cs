using Volo.Abp.Modularity;

namespace Iot.Admin.Application.Contracts;

[DependsOn(
    typeof(IotApplicationContractsModule))]
public class IotAdminApplicationContractsModule : AbpModule
{
}
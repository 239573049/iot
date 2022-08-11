using Volo.Abp.Modularity;

namespace Iot;

[DependsOn(
    typeof(IotApplicationModule),
    typeof(IotDomainTestModule)
    )]
public class IotApplicationTestModule : AbpModule
{

}

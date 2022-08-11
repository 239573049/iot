using Iot.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Iot;

[DependsOn(
    typeof(IotEntityFrameworkCoreTestModule)
    )]
public class IotDomainTestModule : AbpModule
{

}

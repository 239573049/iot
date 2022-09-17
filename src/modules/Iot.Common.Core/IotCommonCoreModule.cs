using Iot.Common.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Iot.Common.Core;

[DependsOn(
    typeof(AbpAutofacModule)
)]
public class IotCommonCoreModule : AbpModule
{
    public override  void ConfigureServices(ServiceConfigurationContext context)
    {
        
    }
}
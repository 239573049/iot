using Consul;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Iot.Consul;

public class IotConsulModule :AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;

        // 加载配置
        services.Configure<ConsulOptions>(services.GetConfiguration().GetSection(ConsulOptions.Name));
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var consulOption = context.ServiceProvider.GetRequiredService<IOptions<ConsulOptions>>().Value;

        var lifetime = context.ServiceProvider.GetRequiredService<IHostApplicationLifetime>();
        
        var consulClient = new ConsulClient(x =>
        {
            x.Address = new Uri(consulOption.Address);
        });
        
        var registration = new AgentServiceRegistration()
        {
            ID = Guid.NewGuid().ToString(),
            Name = consulOption.ServiceName,// 服务名
            Address = consulOption.ServiceIP, // 服务绑定IP
            Port = consulOption.ServicePort, // 服务绑定端口
            Check = new AgentServiceCheck()
            {
                DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(5),//服务启动多久后注册
                Interval = TimeSpan.FromSeconds(10),//健康检查时间间隔
                HTTP = consulOption.ServiceHealthCheck,//健康检查地址
                Timeout = TimeSpan.FromSeconds(5)
            }
        };
        
        consulClient.Agent.ServiceRegister(registration).Wait();
        
        lifetime.ApplicationStopping.Register(() =>
        {
            consulClient.Agent.ServiceDeregister(registration.ID).Wait();
        });
    }
}
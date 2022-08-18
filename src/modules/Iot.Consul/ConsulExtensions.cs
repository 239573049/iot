using Microsoft.Extensions.Hosting;
using Winton.Extensions.Configuration.Consul;

namespace Iot.Consul;

public static class ConsulExtensions
{
    public static IHostBuilder AddConsul(this IHostBuilder hostBuilder,string key)
    {
        hostBuilder.ConfigureAppConfiguration((context, config) =>
        {
            config.AddConsul(key, options =>
            {

                options.ConsulConfigurationOptions = c =>
                {
                    c.Address = new Uri(context.Configuration["Consul:Address"]);
                };
                options.ReloadOnChange = true;
            });
        });
        
        return hostBuilder;
    }
}
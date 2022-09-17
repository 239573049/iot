using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Iot.Common.Core.Extensions;

public static class ServiceCollectionSerilogExtensions
{
    /// <summary>
    /// 注入 Serilog 服务
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddSerilog(this IServiceCollection services)
    {
        var configBuilder = new ConfigurationBuilder();

        string serilogJsonFileName = "serilog.json";
        var hostEnvironment = services.BuildServiceProvider().GetService<IHostEnvironment>();

        if (hostEnvironment != null && !hostEnvironment.IsProduction())
        {
            serilogJsonFileName = $"serilog.{hostEnvironment.EnvironmentName}.json";
        }

        if (!File.Exists(Path.Join(Directory.GetCurrentDirectory(), serilogJsonFileName)))
        {
            throw new FileNotFoundException($"serilog config file '{serilogJsonFileName}' not found");
        }

        configBuilder.AddJsonFile(serilogJsonFileName, optional: true, reloadOnChange: true);

        var configuration = configBuilder.Build();

        Log.Logger = new LoggerConfiguration()
            .ReadFrom
            .Configuration(configuration)
            .CreateLogger();

        services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

        return services;
    }
}
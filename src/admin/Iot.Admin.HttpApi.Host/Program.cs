using System;
using Iot;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;


try
{
    Log.Information("Starting Iot.Admin.HttpApi.Host");
    var builder = WebApplication.CreateBuilder(args);
    builder.Host.AddAppSettingsSecretsJson()
        .UseAutofac()
        .UseSerilog(((context, logger) =>
        {
            logger.ReadFrom.Configuration(context.Configuration)
                .Enrich.FromLogContext();
        }));
    
    await builder.AddApplicationAsync<IotHttpApiHostModule>();

    var app = builder.Build();
    await app.InitializeApplicationAsync();
    
    await app.RunAsync();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly!");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}
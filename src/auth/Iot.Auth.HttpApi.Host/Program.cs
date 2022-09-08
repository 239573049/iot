using Iot.Auth.HttpApi.Host;
using Iot.Consul;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;


Log.Logger = new LoggerConfiguration()
#if DEBUG
    .MinimumLevel.Debug()
#else
            .MinimumLevel.Information()
#endif
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.Async(c => c.File("Logs/logs.txt"))
    .WriteTo.Async(c => c.Console())
    .CreateLogger();

try
{
    Log.Information("Starting Iot.Auth.HttpApi.Host.");
    var builder = WebApplication.CreateBuilder(args);
    builder.Host.AddAppSettingsSecretsJson()
        .AddConsul("iot/auth")
        .UseAutofac()
        .UseSerilog();
    builder.Services.AddControllers();
    await builder.AddApplicationAsync<IotAuthHttpApiHostModule>();
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
using Iot.Auth.HttpApi.Host;
using Iot.Consul;
using Serilog;
using Serilog.Events;


var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("serilog.json", optional: true, reloadOnChange: true)
    .AddJsonFile("serilog.Development.json", optional: true, reloadOnChange: true)
    .Build();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(config)
    
#if DEBUG
    .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.Async(c => c.File("logs/logs.txt"))
#if DEBUG
    .WriteTo.Async(c => c.Console())
#endif
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
    app.MapControllers();
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
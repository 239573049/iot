using Iot.Auth.HttpApi.Host;
using Serilog;

try
{
    Log.Information("Starting Iot.Auth.HttpApi.Host");
    var builder = WebApplication.CreateBuilder(args);
    builder.Host.AddAppSettingsSecretsJson()
        // .AddConsul("iot/auth")
        .UseAutofac()
        .UseSerilog(((context, logger) =>
        {
            logger.ReadFrom.Configuration(context.Configuration)
                .Enrich.FromLogContext();
        }));
    
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
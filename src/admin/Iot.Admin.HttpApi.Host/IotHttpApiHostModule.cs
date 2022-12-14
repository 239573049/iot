using Iot.Admin.Application;
using Iot.EntityFrameworkCore;
using Iot.HttpApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSwag;
using NSwag.Generation.Processors.Security;
using StackExchange.Redis;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Iot;

[DependsOn(
    // typeof(IotConsulModule), // 默认不使用Consul
    typeof(AbpAutofacModule),
    typeof(IotHttpApiModule),
    typeof(IotAdminApplicationModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(IotApplicationModule),
    typeof(IotEntityFrameworkCoreModule),
    typeof(IotAdminHttpApiModule),
    typeof(AbpAspNetCoreSerilogModule)
)]
public class IotHttpApiHostModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        var hostingEnvironment = context.Services.GetHostingEnvironment();

        context.Services.AddHealthChecks();

        ConfigureConventionalControllers();
        ConfigureLocalization();
        ConfigureCache();
        ConfigureDataProtection(context, configuration, hostingEnvironment);
        ConfigureCors(context);
        ConfigureSwaggerServices(context);
    }

    private void ConfigureCache()
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "Iot:"; });
    }

    private void ConfigureConventionalControllers()
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(IotApplicationModule).Assembly);
            options.ConventionalControllers.Create(typeof(IotAdminApplicationModule).Assembly);
        });
    }

    private static void ConfigureSwaggerServices(ServiceConfigurationContext context)
    {
        context.Services.AddSwaggerDocument(options =>
        {
            options.UseControllerSummaryAsTagDescription = true;
            options.PostProcess = document =>
            {
                document.Info.Version = "v1.0.1";
                document.Info.Title = "Iot 管理平台";
                document.Info.Description = "Iot 管理平台 api";
            };
            options.AddSecurity("Bearer",
                new OpenApiSecurityScheme
                {
                    Type = OpenApiSecuritySchemeType.ApiKey,
                    Name = "Bearer",
                    Description = "token"
                });
            
            options.UseXmlDocumentation = true;

            options.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("Bearer"));
        });
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
        });
    }

    private void ConfigureDataProtection(
        ServiceConfigurationContext context,
        IConfiguration configuration,
        IWebHostEnvironment hostingEnvironment)
    {
        var dataProtectionBuilder = context.Services.AddDataProtection().SetApplicationName("Iot");
        if (!hostingEnvironment.IsDevelopment())
        {
            var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
            dataProtectionBuilder.PersistKeysToStackExchangeRedis(redis, "Iot-Protection-Keys");
        }
    }

    private void ConfigureCors(ServiceConfigurationContext context)
    {
        context.Services.AddCors(options =>
        {
            options.AddPolicy(Constants.CorsPolicy, corsBuilder =>
            {
                corsBuilder.SetIsOriginAllowed((string _) => true).AllowAnyMethod().AllowAnyHeader()
                    .AllowCredentials();
            });
        });
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseAbpRequestLocalization();
        app.UseCorrelationId();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseCors(Constants.CorsPolicy);
        app.UseAuthentication();


        app.UseOpenApi();
        app.UseSwaggerUi3();

        app.UseHealthChecks("/healthCheck");

        app.UseAuditing();
        app.UseAbpSerilogEnrichers();
        app.UseUnitOfWork();
        app.UseConfiguredEndpoints();
    }
}
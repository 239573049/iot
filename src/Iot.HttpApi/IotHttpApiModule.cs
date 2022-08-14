using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc.AntiForgery;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.AspNetCore.Mvc.Validation;
using Volo.Abp.Modularity;

namespace Iot.HttpApi;

public class IotHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;

        services.AddMvcCore(options =>
        {
            options.Filters.Add<IotResponseFilter>();
            options.Filters.Add<IotExceptionFilter>();
        });
        
        Configure<AbpAntiForgeryOptions>(x =>
        {
            x.AutoValidate = false;
        });
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        
        var app = context.GetApplicationBuilder();
        
        var ops = app.ApplicationServices.GetRequiredService<IOptions<MvcOptions>>().Value;
        var abpExceptionFilter = ops.Filters.FirstOrDefault(a => (a as ServiceFilterAttribute)?.ServiceType == (typeof(AbpExceptionFilter)));

        if (abpExceptionFilter != null)
        {
            ops.Filters.Remove(abpExceptionFilter);
        }

    }
}
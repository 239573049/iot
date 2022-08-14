using Iot.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Iot.HttpApi;

public class IotExceptionFilter : ExceptionFilterAttribute
{
    private readonly IStringLocalizer<IotResource> _localizer;
    private readonly ILogger<IotExceptionFilter> _logger;

    public IotExceptionFilter(IStringLocalizer<IotResource> localizer, ILogger<IotExceptionFilter> logger)
    {
        _localizer = localizer;
        _logger = logger;
    }

    public override Task OnExceptionAsync(ExceptionContext context)
    {
        string error = string.Empty;

        if (context.Exception is BusinessException ex)
        {
            error = _localizer[ex.Code];
        }
        else
        {
            error = context.Exception.Message;
        }

        _logger.LogError("message:{0}", context.Exception);
        context.Result = new ObjectResult(new Result(code: "500", message: error));

        context.ExceptionHandled = true;

        return Task.CompletedTask;
    }
}
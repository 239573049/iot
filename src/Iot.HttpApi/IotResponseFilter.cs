using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Iot.HttpApi;

public class IotResponseFilter : ActionFilterAttribute
{
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.Result != null)
        {
            if (context.Result is ObjectResult)
            {
                ObjectResult? objectResult = context.Result as ObjectResult;
                if (objectResult?.Value?.GetType().Name == nameof(Result))
                {
                    Result? modelStateResult = objectResult.Value as Result;

                    context.Result = new ObjectResult(modelStateResult);
                }
                else
                {
                    context.Result = new ObjectResult(new Result("200", data: objectResult?.Value));
                }
            }
            else if (context.Result is EmptyResult)
            {
                // context.Result = new ObjectResult(new Result("200"));
            }
            else if (context.Result is Result modelStateResult2)
            {
                context.Result = new ObjectResult(modelStateResult2);
            }
        }
        base.OnActionExecuted(context);
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Iot.HttpApi;

public class Result : ActionResult
{
    public string Code { get; set; }

    public string? Message { get; set; }

    public object? Data { get; set; }

    public Result(string code = "400", string? message = null, object? data = null)
    {
        Code = code;
        Message = message;
        Data = data;
    }

    public Result()
    {
    }
}
using Castle.Core.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using Volo.Abp.EventBus.RabbitMq;

namespace Iot.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConfigController : ControllerBase
{

    [HttpGet("data")]
    public string Get()
    {
        
        return "ok";    
    }
}
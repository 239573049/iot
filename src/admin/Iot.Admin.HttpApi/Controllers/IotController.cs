using Iot.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Iot.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class IotController : AbpControllerBase
{
    protected IotController()
    {
        LocalizationResource = typeof(IotResource);
    }
}

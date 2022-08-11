using System;
using System.Collections.Generic;
using System.Text;
using Iot.Localization;
using Volo.Abp.Application.Services;

namespace Iot;

/* Inherit your application services from this class.
 */
public abstract class IotAppService : ApplicationService
{
    protected IotAppService()
    {
        LocalizationResource = typeof(IotResource);
    }
}

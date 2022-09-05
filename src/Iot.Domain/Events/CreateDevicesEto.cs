using System;
using System.Collections.Generic;
using Volo.Abp.EventBus;

namespace Iot.Events;

[EventName("Iot.Admin.CreateDevice")]
public class CreateDevicesEto
{
    /// <summary>
    /// 设备id
    /// </summary>
    public Guid DeviceId { get; }

    /// <summary>
    /// 设备模板Id
    /// </summary>
    public Guid DeviceTemplateId { get; }
    
    public Dictionary<string,object> Data { get; }

    public CreateDevicesEto(Guid deviceId, Dictionary<string,object> data, Guid deviceTemplateId)
    {
        DeviceId = deviceId;
        Data = data;
        DeviceTemplateId = deviceTemplateId;
    }
}
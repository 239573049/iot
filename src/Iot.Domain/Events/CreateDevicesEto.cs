using System;
using Volo.Abp.EventBus;

namespace Iot.Events;

[EventName("Iot.Admin.CreateDevice")]
public class CreateDevicesEto
{
    public Guid DeviceId { get; set; }

    public object Data { get; set; }

    public CreateDevicesEto(Guid deviceId, object data)
    {
        DeviceId = deviceId;
        Data = data;
    }
}
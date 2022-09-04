using System;

namespace Iot.Devices;

public class DeviceLogView
{
    public Guid Id { get; set; }

    public DeviceType Type { get; set; }

    public string Data { get; set; }
    
    public DateTime CreationTime { get; set; }
}
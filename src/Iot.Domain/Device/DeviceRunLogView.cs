using System;
using System.Collections.Generic;

namespace Iot.Device;

public class DeviceRunLogView : IotAggregateRoot<Guid>
{
    /// <summary>
    /// 设备名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 设备编号
    /// </summary>
    public Guid DeviceId { get; set; }

    /// <summary>
    /// 运行信息
    /// </summary>
    public Dictionary<string, object> Logs { get; set; }

    public DeviceRunLogView(Guid id,DateTime creationTime,
        string name, Guid deviceId, Dictionary<string, object> logs)
    {
        id = id;
        CreationTime = creationTime;
        Name = name;
        DeviceId = deviceId;
        Logs = logs;
    }
}
using System;
using System.Collections.Generic;

namespace Iot.Device;

public class DeviceRunLogView : IotAggregateRoot<Guid>
{
    /// <summary>
    /// 设备名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 设备图标
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get;  set; }
    
    /// <summary>
    /// 设备类型
    /// </summary>
    public string Type { get;  set; }
    
    /// <summary>
    /// 设备编号
    /// </summary>
    public Guid DeviceId { get; set; }

    /// <summary>
    /// 运行信息
    /// </summary>
    public Dictionary<string, string> Logs { get; set; }

    public DeviceRunLogView(Guid id,DateTime creationTime,
        string name, Guid deviceId, Dictionary<string, string> logs)
    {
        id = id;
        CreationTime = creationTime;
        Name = name;
        DeviceId = deviceId;
        Logs = logs;
    }
}
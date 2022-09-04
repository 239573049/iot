using System;
using System.Collections.Generic;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Iot.Devices;

public class DeviceRunLog : Entity<Guid>, IHasCreationTime
{
    /// <summary>
    /// 设备编号
    /// </summary>
    public Guid DeviceId { get; protected set; }

    /// <summary>
    /// 运行信息
    /// </summary>
    public Dictionary<string, string> Logs { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>

    public DateTime CreationTime { get; }

    public DeviceRunLog()
    {
        Logs = new Dictionary<string, string>();
    }

    public DeviceRunLog(Guid id, Guid deviceId, DateTime creationTime) : base(id)
    {
        DeviceId = deviceId;
        CreationTime = creationTime;
        Logs = new Dictionary<string, string>();
    }
}
using System;
using System.Collections.Generic;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Iot.Device;

public class DeviceRunLog : Entity<Guid>, IHasCreationTime
{
    /// <summary>
    /// 设备编号
    /// </summary>
    public Guid DeviceId { get; protected set; }

    /// <summary>
    /// 运行信息
    /// </summary>
    public Dictionary<string, string> Logs { get; protected set; }

    /// <summary>
    /// 创建时间
    /// </summary>

    public DateTime CreationTime { get;  set; }

    public DeviceRunLog()
    {
        Logs = new Dictionary<string, string>();
    }

    public DeviceRunLog(Guid id, Guid deviceId, Dictionary<string, string> logs) : base(id)
    {
        DeviceId = deviceId;
        Logs = logs;
    }
}
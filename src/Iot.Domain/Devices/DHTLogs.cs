using System;
using System.Collections.Generic;
using System.Runtime;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Iot.Devices;

/// <summary>
/// DHT运行记录
/// </summary>
public class DHTxxLogs : AggregateRoot<Guid>, IHasDeletionTime, IHasCreationTime, IMayHaveCreator
{
    /// <summary>
    /// 设备编号
    /// </summary>
    public Guid DeviceId { get; protected set; }

    /// <summary>
    /// 运行信息
    /// </summary>
    public Dictionary<string, string> Logs { get; protected set; }

    public virtual IotDevices Device { get; protected set; }

    public DHTxxLogs()
    {
    }

    public DHTxxLogs(Guid id,Guid deviceId) : base(id)
    {
        DeviceId = deviceId;
    }

    public bool IsDeleted { get; set; }
    public DateTime? DeletionTime { get; set; }
    public DateTime CreationTime { get; set; }
    public Guid? CreatorId { get; }
}
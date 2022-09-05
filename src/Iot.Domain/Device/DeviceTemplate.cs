using System;
using Iot.Users;

namespace Iot.Devices;

public class DeviceTemplate : IotAggregateRoot<Guid>
{
    /// <summary>
    /// 设备名称
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// 设备图标
    /// </summary>
    public string Icon { get; protected set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public string Type { get; protected set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; protected set; }

    /// <summary>
    /// 用户id 为空则是通用模板
    /// </summary>
    public Guid? UserId { get; set; }

    public virtual UserInfo User { get; set; }

    public DeviceTemplate(Guid id,string name, string icon, string type, string remark, Guid? userId)
    {
        Id = id;
        Name = name;
        Icon = icon;
        Type = type;
        Remark = remark;
        UserId = userId;
    }
}
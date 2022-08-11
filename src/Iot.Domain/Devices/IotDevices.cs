using System;
using Iot.Users;

namespace Iot.Devices;

public class IotDevices : IotAggregateRoot<Guid>
{
    /// <summary>
    /// 设备名称
    /// </summary>
    public string? Name { get; protected set; }

    /// <summary>
    /// 设备图标
    /// </summary>
    public string? Icon { get; protected set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public DeviceType Type { get; protected set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; protected set; }

    /// <summary>
    /// 状态
    /// </summary>
    public DeviceStats Stats { get; protected set; }

    /// <summary>
    /// 绑定设备
    /// </summary>
    public Guid? UserInfoId { get; protected set; }

    public virtual UserInfo UserInfo { get; set; }

    public IotDevices()
    {
    }

    public IotDevices(Guid id, string name, string icon, DeviceType type, string remark, DeviceStats stats,
        Guid? userInfoId) : base(id)
    {
        Name = name;
        Icon = icon;
        Type = type;
        Remark = remark;
        Stats = stats;
        UserInfoId = userInfoId;
    }
}
using System;
using Volo.Abp.Domain.Entities;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DeviceView : Entity<Guid>
{
    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public DeviceStats Stats { get; set; }

    /// <summary>
    /// 设备名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 最后活跃时间
    /// </summary>
    public DateTime? LastTime { get; set; }

    /// <summary>
    /// 绑定设备
    /// </summary>
    public Guid? UserInfoId { get; set; }

    /// <summary>
    /// 设备模板
    /// </summary>
    public Guid? DeviceTemplateId { get; set; }
    
    /// <summary>
    /// 设备图标
    /// </summary>
    public string Icon { get;  set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public string Type { get;  set; }

    public DeviceView(Guid id, string remark, DeviceStats stats, string name, DateTime? lastTime, Guid? userInfoId, Guid? deviceTemplateId, string icon, string type) : base(id)
    {
        Remark = remark;
        Stats = stats;
        Name = name;
        LastTime = lastTime;
        UserInfoId = userInfoId;
        DeviceTemplateId = deviceTemplateId;
        Icon = icon;
        Type = type;
    }
}
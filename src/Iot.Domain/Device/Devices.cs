using System;
using Iot.Devices;
using Iot.Users;
using Volo.Abp;

namespace Iot.Device;

public class Devices : IotAggregateRoot<Guid>
{

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; protected set; }

    /// <summary>
    /// 状态
    /// </summary>
    public DeviceStats Stats { get; protected set; }

    /// <summary>
    /// 设备名称
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// 最后活跃时间
    /// </summary>
    public DateTime? LastTime { get; set; }
    
    public void SetStats(DeviceStats stats)
    {
        if (stats == Stats)
        {
            return;
        }

        Stats = stats;
    }

    /// <summary>
    /// 绑定设备
    /// </summary>
    public Guid? UserInfoId { get; protected set; }

    /// <summary>
    /// 设备模板
    /// </summary>
    public Guid? DeviceTemplateId { get; set; }

    public void SetUserInfoId(Guid userInfoId)
    {
        if (userInfoId == Guid.Empty)
        {
            throw new BusinessException(IotDomainErrorCodes.NotUserInfoId);
        }
    }

    public virtual UserInfo UserInfo { get; set; }

    public virtual DeviceTemplate DeviceTemplate { get; set; }
    
    public Devices()
    {
    }

    public Devices(string remark, DeviceStats stats, Guid? userInfoId, Guid deviceTemplateId)
    {
        Remark = remark;
        Stats = stats;
        UserInfoId = userInfoId;
        DeviceTemplateId = deviceTemplateId;
    }
}
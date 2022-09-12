using Iot.Common.Core.Extensions;

namespace Iot.Admin.Application.Contracts.Devices.Views;

public class IotDevicesDto
{
    public Guid Id { get; set; }

    /// <summary>
    /// 设备名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 设备图标
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public string Type { get; set; }
    
    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public DeviceStats Stats { get; set; }

    public string StatsName
    {
        get
        {
            return Stats.GetDescription();
        }
    }

    /// <summary>
    /// 绑定设备
    /// </summary>
    public Guid? UserInfoId { get; set; }
}
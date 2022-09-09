using Volo.Abp.Application.Dtos;

namespace Iot.Admin.Application.Contracts.Devices.Views;

/// <summary>
/// 设备列表模型
/// </summary>
public class DeviceTemplateDto : EntityDto<Guid>
{
    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public string Stats { get; set; }

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
    
    
}
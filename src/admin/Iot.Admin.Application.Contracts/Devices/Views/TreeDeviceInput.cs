using Volo.Abp.Application.Dtos;

namespace Iot.Admin.Application.Contracts.Devices.Views;

/// <summary>
/// 创建设备树形模型
/// </summary>
public class TreeDeviceInput : EntityDto<Guid>
{
    /// <summary>
    /// 标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; set; }
}
namespace Iot.Admin.Application.Contracts.Devices.Views;

/// <summary>
/// 创建设备模型
/// </summary>
public class CreateDeviceInput
{
    /// <summary>
    /// 设备模板
    /// </summary>
    public Guid? DeviceTemplateId { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public DeviceStats Stats { get; set; }

    /// <summary>
    /// 设备名称
    /// </summary>
    public string? Name { get; set; }
}
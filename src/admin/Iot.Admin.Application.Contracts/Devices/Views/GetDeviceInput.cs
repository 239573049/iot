namespace Iot.Admin.Application.Contracts.Devices.Views;

public class GetDeviceInput : IotInput
{
    /// <summary>
    /// 设备状态
    /// </summary>
    public DeviceStats? Stats { get; set; }

    /// <summary>
    /// 指定模板Id
    /// </summary>
    public Guid? TemplateId { get; set; }
}
namespace Iot.Admin.Application.Contracts.Devices.Views;

public class GetDeviceLogListInput : IotInput
{
    /// <summary>
    /// id
    /// </summary>
    public Guid? DeviceId { get; set; }

    /// <summary>
    /// 是否设备
    /// </summary>
    public bool? Device { get; set; }
}
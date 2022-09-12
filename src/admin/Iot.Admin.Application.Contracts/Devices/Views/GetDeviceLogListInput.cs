namespace Iot.Admin.Application.Contracts.Devices.Views;

public class GetDeviceLogListInput : IotInput
{
    public Guid? DeviceId { get; set; }

}
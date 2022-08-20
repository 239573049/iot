namespace Iot.Admin.Application.Contracts.Devices.Views;

public class GetDeviceLogListInput : IotInput
{
    public Guid DeviceId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}
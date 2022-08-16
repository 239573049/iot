namespace Iot.Admin.Application.Contracts.Devices.Views;

public class DeviceLogDto
{
    public Guid Id { get; set; }

    public DeviceType Type { get; set; }

    public string? Data { get; set; }
    
    public DateTime CreationTime { get; set; }
}
namespace Iot.Admin.Application.Contracts.Devices;

public interface IDevicesService
{
    /// <summary>
    /// 绑定设备
    /// </summary>
    /// <param name="deviceId"></param>
    /// <returns></returns>
    Task<Guid> BinDeviceAsync(Guid deviceId);
}
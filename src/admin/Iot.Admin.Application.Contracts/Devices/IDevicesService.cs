namespace Iot.Admin.Application.Contracts.Devices;

/// <summary>
/// 设备管理
/// </summary>
public interface IDevicesService
{
    /// <summary>
    /// 绑定设备
    /// </summary>
    /// <param name="deviceId"></param>
    /// <returns></returns>
    Task<Guid> BinDeviceAsync(Guid deviceId);

    /// <summary>
    /// 添加设备运行日志
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    Task SaveDeviceLogAsync(Dictionary<string,object> data);
}
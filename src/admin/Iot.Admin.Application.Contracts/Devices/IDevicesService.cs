using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Admin.Application.Contracts.Events;

namespace Iot.Admin.Application.Contracts.Devices;

public interface IDevicesService
{
    /// <summary>
    /// 添加设备
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task CreateAsync(CreateDeviceInput input);

    /// <summary>
    /// 创建设备记录
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    Task CreateLogsAsync(DHTDto data);
}
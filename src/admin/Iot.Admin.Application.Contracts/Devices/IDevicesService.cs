using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Admin.Application.Contracts.Events;
using Volo.Abp.Application.Dtos;

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

    /// <summary>
    /// 获取设备列表
    /// </summary>
    /// <returns></returns>
    Task<PagedResultDto<IotDevicesDto>> GetListAsync(GetListInput input);

    /// <summary>
    /// 获取设备运行信息
    /// </summary>
    /// <param name="deviceId"></param>
    /// <returns></returns>
    Task<DeviceLogDto> GetDeviceLogAsync(Guid deviceId);
}
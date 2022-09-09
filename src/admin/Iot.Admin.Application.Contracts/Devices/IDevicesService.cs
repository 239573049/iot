using Iot.Admin.Application.Contracts.Devices.Views;
using Volo.Abp.Application.Dtos;

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

    /// <summary>
    /// 获取设备列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<PagedResultDto<DeviceDto>> GetListAsync(GetDeviceInput input);

    /// <summary>
    /// 创建设备
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task CreateAsync(CreateDeviceInput input);
}
using Iot.Admin.Application.Contracts.Devices.Views;
using Volo.Abp.Application.Dtos;

namespace Iot.Admin.Application.Contracts.Devices;

public interface IDeviceRunLogService
{
    /// <summary>
    /// 设备运行日志
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<PagedResultDto<DeviceRunLogDto>> GetListAsync(GetDeviceLogListInput input);
}
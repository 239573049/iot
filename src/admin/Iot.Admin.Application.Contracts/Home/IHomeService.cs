using Iot.Admin.Application.Contracts.Home.DeviceView;

namespace Iot.Admin.Application.Contracts.Home;

public interface IHomeService
{
    /// <summary>
    /// 获取用户首页展示数据
    /// </summary>
    /// <returns></returns>
    Task<DeviceHomeDto> GetDeviceHomeAsync();

    /// <summary>
    /// 获取
    /// </summary>
    /// <returns></returns>
    Task<DeviceDateLogDto> GetDeviceDateLogAsync(GetDeviceDateLogInput input);
}
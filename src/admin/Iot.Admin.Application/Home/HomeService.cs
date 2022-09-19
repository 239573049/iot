using Iot.Admin.Application.Contracts.Home;
using Iot.Admin.Application.Contracts.Home.DeviceView;
using Iot.Common.Jwt;
using Iot.Device;
using Volo.Abp.Application.Services;

namespace Iot.Admin.Application.Home;

/// <summary>
/// 首页展示
/// </summary>
public class HomeService : ApplicationService, IHomeService
{
    private readonly Accessor _accessor;
    private readonly IDevicesRepository _devicesRepository;
    private readonly IDeviceRunLogRepository _deviceRunLogRepository;

    /// <inheritdoc />
    public HomeService(Accessor accessor, IDevicesRepository devicesRepository,
        IDeviceRunLogRepository deviceRunLogRepository)
    {
        _accessor = accessor;
        _devicesRepository = devicesRepository;
        _deviceRunLogRepository = deviceRunLogRepository;
    }

    /// <inheritdoc />
    public async Task<DeviceHomeDto> GetDeviceHomeAsync()
    {
        var userId = _accessor.GetUserId();

        var result = await _devicesRepository.GetDeviceHomeAsync(userId);

        var dto = ObjectMapper.Map<DeviceHomeView, DeviceHomeDto>(result);

        return dto;
    }

    /// <inheritdoc />
    public async Task<DeviceDateLogDto> GetDeviceDateLogAsync(GetDeviceDateLogInput input)
    {
        var userId = _accessor.GetUserId();

        var now = DateTime.Now;
        input.StartTime = now.AddDays(-7);
        input.EndTime = now;

        var log = await _deviceRunLogRepository.GetQueryAsync(userId, input.StartTime, input.EndTime);

        var deviceDateLogDto = new DeviceDateLogDto();


        var devices = log.GroupBy(x => x.CreationTime.ToString("yyyy-MM-dd"));

        deviceDateLogDto.Date.AddRange(devices.Select(x => x.Key));

        foreach (var device in devices)
        {
            var series = new Series();
            series.Data.Add(device.Count());
            deviceDateLogDto.Series.Add(series);
        }


        return deviceDateLogDto;
    }
}
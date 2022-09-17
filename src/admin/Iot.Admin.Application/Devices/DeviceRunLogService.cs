using Iot.Admin.Application.Contracts.Devices;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Device;
using Microsoft.Extensions.Logging;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Iot.Admin.Application.Devices;

/// <summary>
/// 设备运行日志
/// </summary>
public class DeviceRunLogService : ApplicationService, IDeviceRunLogService
{
    private readonly ILogger<DeviceRunLogService> _logger;
    private readonly IDeviceRunLogRepository _deviceRunLogRepository;

    /// <inheritdoc />
    public DeviceRunLogService(IDeviceRunLogRepository deviceRunLogRepository, ILogger<DeviceRunLogService> logger)
    {
        _deviceRunLogRepository = deviceRunLogRepository;
        _logger = logger;
    }


    /// <inheritdoc />
    public async Task<PagedResultDto<DeviceRunLogDto>> GetListAsync(GetDeviceLogListInput input)
    {
        _logger.LogDebug("测试测试");
        var result = await _deviceRunLogRepository.GetDeviceRunLogListAsync(input.Keywords, input.Device, input.DeviceId,
            input.StartTime, input.EndTime, input.SkipCount, input.MaxResultCount);

        var count = await _deviceRunLogRepository.GetDeviceRunLogCountAsync(input.Device, input.Keywords, input.DeviceId,
            input.StartTime, input.EndTime);

        var dto = ObjectMapper.Map<List<DeviceRunLogView>, List<DeviceRunLogDto>>(result);

        return new PagedResultDto<DeviceRunLogDto>(count,dto);
    }
}
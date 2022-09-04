using Iot.Admin.Application.Contracts.Devices;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Admin.Application.Contracts.Events;
using Iot.Common.Jwt;
using Iot.Devices;
using Iot.Events;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.EventBus.Distributed;

namespace Iot.Admin.Application.Devices;

public class DevicesService : ApplicationService, IDevicesService
{
    private readonly Accessor _accessor;
    private readonly IDevicesRepository _devicesRepository;
    private readonly IDistributedEventBus _distributedEventBus;

    public DevicesService(Accessor accessor, IDevicesRepository devicesRepository,
        IDistributedEventBus distributedEventBus)
    {
        _accessor = accessor;
        _devicesRepository = devicesRepository;
        _distributedEventBus = distributedEventBus;
    }

    /// <inheritdoc />
    public async Task CreateAsync(CreateDeviceInput input)
    {
        var userId = _accessor.GetUserId();
        var data = ObjectMapper.Map<CreateDeviceInput, Device.Devices>(input);
        data.SetUserInfoId(userId);
        data.SetStats(DeviceStats.OffLine);
        await _devicesRepository.InsertAsync(data);
    }

    /// <inheritdoc />
    public async Task<IotDevicesDto> GetAsync(Guid id)
    {
        var data = await _devicesRepository.GetAsync(id);

        var dto = ObjectMapper.Map<Device.Devices, IotDevicesDto>(data);

        return dto;
    }

    /// <inheritdoc />
    public async Task<bool> CreateLogsAsync(DHTDto data)
    {
        var deviceId = _accessor.GetDeviceId();
        if (deviceId == null)
        {
            throw new BusinessException(IotDomainErrorCodes.NotNullDeviceId);
        }

        await _distributedEventBus.PublishAsync(new CreateDevicesEto((Guid)deviceId, data), false);
        return true;
    }

    /// <inheritdoc />
    public async Task<PagedResultDto<IotDevicesDto>> GetListAsync(GetListInput input)
    {
        var userId = _accessor.GetUserId();

        var result =
            await _devicesRepository.GetListAsync(userId, input.Keywords, input.SkipCount, input.MaxResultCount);

        var count = await _devicesRepository.GetCountAsync(userId, input.Keywords);

        var dto = ObjectMapper.Map<List<Device.Devices>, List<IotDevicesDto>>(result);

        return new PagedResultDto<IotDevicesDto>(count, dto);
    }

    /// <inheritdoc />
    public async Task<DeviceLogDto> GetDeviceLogAsync(Guid deviceId)
    {
        var result = await _devicesRepository.GetDeviceLogAsync(deviceId);

        result.CreationTime = result.CreationTime.AddHours(8);
        var dto = ObjectMapper.Map<DeviceLogView, DeviceLogDto>(result);

        return dto;
    }

    public async Task<PagedResultDto<DeviceLogDto>> GetDeviceLogListAsync(GetDeviceLogListInput input)
    {
        var result = await _devicesRepository.GetDeviceLogListAsync(input.DeviceId, input.StartTime, input.EndTime,
            input.SkipCount, input.MaxResultCount);

        var count = await _devicesRepository.GetDeviceLogCountAsync(input.DeviceId, input.StartTime, input.EndTime);

        var dto = ObjectMapper.Map<List<DeviceLogView>, List<DeviceLogDto>>(result);

        return new PagedResultDto<DeviceLogDto>(count, dto);
    }

    public Task BinDeviceAsync(Guid device)
    {
        var userId = _accessor.GetUserId();

        throw new BusinessException();
    }
}
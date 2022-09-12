using System.ComponentModel;
using Iot.Admin.Application.Contracts.Devices;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Common.Jwt;
using Iot.Device;
using Iot.EntityFrameworkCore.Repositorys;
using Iot.Events;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace Iot.Admin.Application.Devices;

/// <summary>
/// 设备管理
/// </summary>
public class DevicesService : ApplicationService, IDevicesService
{
    private readonly Accessor _accessor;
    private readonly IDeviceTemplateRepository _deviceTemplateRepository;
    private readonly IDevicesRepository _devicesRepository;
    private readonly IDistributedEventBus _distributedEventBus;
    private readonly IDeviceRunLogRepository _deviceRunLogRepository;

    /// <inheritdoc />
    public DevicesService(Accessor accessor, IDevicesRepository devicesRepository,
        IDistributedEventBus distributedEventBus, IDeviceTemplateRepository deviceTemplateRepository,
        IDeviceRunLogRepository deviceRunLogRepository)
    {
        _accessor = accessor;
        _devicesRepository = devicesRepository;
        _distributedEventBus = distributedEventBus;
        _deviceTemplateRepository = deviceTemplateRepository;
        _deviceRunLogRepository = deviceRunLogRepository;
    }

    /// <inheritdoc />
    public async Task<Guid> BinDeviceAsync(Guid deviceId)
    {
        var userId = _accessor.GetUserId();

        var devices = await _devicesRepository.FirstOrDefaultAsync(x => x.Id == deviceId);

        if (devices == null)
        {
            var template = await _deviceTemplateRepository.FirstOrDefaultAsync(x => x.Id == deviceId);

            devices = new Device.Devices(Guid.NewGuid(), template.Remark, DeviceStats.OffLine, userId, template.Id);

            devices = await _devicesRepository.InsertAsync(devices);
        }
        else
        {
            devices.SetUserInfoId(userId);
            await _devicesRepository.UpdateAsync(devices);
        }


        return devices.Id;
    }

    /// <inheritdoc />
    public async Task SaveDeviceLogAsync(Dictionary<string, object> data)
    {
        // 将日志添加到分布式事件总线处理
        await _distributedEventBus.PublishAsync(new CreateDevicesEto(_accessor.GetDeviceId(), data,
            _accessor.GetDeviceTemplateId()));
    }

    /// <inheritdoc />
    public async Task<PagedResultDto<DeviceDto>> GetListAsync(GetDeviceInput input)
    {
        var userId = _accessor.GetUserId();
        var result = await _devicesRepository.GetListAsync(input.Keywords, userId, input.Stats, input.TemplateId,
            input.StartTime,
            input.EndTime, input.SkipCount, input.MaxResultCount);

        var count = await _devicesRepository.GetCountAsync(input.Keywords, input.Stats, userId, input.TemplateId,
            input.StartTime,
            input.EndTime);

        var dto = ObjectMapper.Map<List<DeviceView>, List<DeviceDto>>(result);

        return new PagedResultDto<DeviceDto>(count, dto);
    }

    /// <inheritdoc />
    public async Task CreateAsync(CreateDeviceInput input)
    {
        var userId = _accessor.GetUserId();
        var template = await _deviceTemplateRepository.AnyAsync(x => x.Id == input.DeviceTemplateId);

        if (!template)
        {
            throw new ArgumentNullException(nameof(input.DeviceTemplateId));
        }

        var data = ObjectMapper.Map<CreateDeviceInput, Device.Devices>(input);
        data.SetUserInfoId(userId);

        data = await _devicesRepository.InsertAsync(data, true);
    }

    /// <inheritdoc />
    public async Task<DeviceHomeDto> GetDeviceHomeAsync()
    {
        var userId = _accessor.GetUserId();

        var result = await _devicesRepository.GetDeviceHomeAsync(userId);

        var dto = ObjectMapper.Map<DeviceHomeView, DeviceHomeDto>(result);

        return dto;
    }
}
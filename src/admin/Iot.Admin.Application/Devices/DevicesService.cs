using Iot.Admin.Application.Contracts.Devices;
using Iot.Common.Jwt;
using Iot.Device;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace Iot.Admin.Application.Devices;

public class DevicesService : ApplicationService, IDevicesService
{
    private readonly Accessor _accessor;
    private readonly IDeviceTemplateRepository _deviceTemplateRepository;
    private readonly IDevicesRepository _devicesRepository;
    private readonly IDistributedEventBus _distributedEventBus;

    public DevicesService(Accessor accessor, IDevicesRepository devicesRepository,
        IDistributedEventBus distributedEventBus, IDeviceTemplateRepository deviceTemplateRepository)
    {
        _accessor = accessor;
        _devicesRepository = devicesRepository;
        _distributedEventBus = distributedEventBus;
        _deviceTemplateRepository = deviceTemplateRepository;
    }

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
}
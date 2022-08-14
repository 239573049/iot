using Iot.Admin.Application.Contracts.Devices;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Admin.Application.Contracts.Events;
using Iot.Common.Jwt;
using Iot.Devices;
using Iot.Events;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.EventBus.RabbitMq;

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
        var data = ObjectMapper.Map<CreateDeviceInput, IotDevices>(input);
        data.SetUserInfoId(userId);
        data.SetStats(DeviceStats.OffLine);
        await _devicesRepository.InsertAsync(data);
    }

    /// <inheritdoc />
    public async Task CreateLogsAsync(DHTDto data)
    {
        var deviceId = _accessor.GetDeviceId();
        if (deviceId == null)
        {
            throw new BusinessException(IotDomainErrorCodes.NotNullDeviceId);
        }

        await _distributedEventBus.PublishAsync(new CreateDevicesEto((Guid)deviceId, data));
    }
}
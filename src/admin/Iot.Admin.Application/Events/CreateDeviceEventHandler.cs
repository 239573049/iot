using Iot.Admin.Application.Contracts.Events;
using Iot.Devices;
using Iot.Events;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Uow;

namespace Iot.Admin.Application.Events;

public class CreateDeviceEventHandler : IDistributedEventHandler<CreateDevicesEto>, ITransientDependency
{
    private readonly ILogger<CreateDeviceEventHandler> _logger;
    private readonly IUnitOfWorkManager _uowManager;
    private readonly IDevicesRepository _devicesRepository;
    public CreateDeviceEventHandler(ILogger<CreateDeviceEventHandler> logger,  IDevicesRepository devicesRepository, IUnitOfWorkManager uowManager)
    {
        _logger = logger;
        _devicesRepository = devicesRepository;
        _uowManager = uowManager;
    }

    public async Task HandleEventAsync(CreateDevicesEto eventData)
    {
        using var uow = _uowManager.Begin(new(), true);
        
        var device = await _devicesRepository.FirstOrDefaultAsync(x => x.Id == eventData.DeviceId);

        if (device == null)
        {
            _logger.LogWarning("未找到{0} , 写入数据：{1}", eventData.DeviceId, eventData.Data);

            return;
        }

        await uow.CompleteAsync();
    }

}
using Iot.Device;
using Iot.Devices;
using Iot.Events;
using Microsoft.Extensions.Logging;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Uow;

namespace Iot.Admin.Application.Events;

/// <summary>
/// 新增日志
/// </summary>
public class CreateDeviceEventHandler : ILocalEventHandler<CreateDevicesEto>, ITransientDependency
{
    private readonly ILogger<CreateDeviceEventHandler> _logger;
    private readonly IUnitOfWorkManager _uowManager;
    private readonly IDevicesRepository _devicesRepository;
    private readonly IDeviceTemplateRepository _deviceTemplateRepository;
    private readonly IDeviceRunLogRepository _deviceRunLogRepository;

    public CreateDeviceEventHandler(ILogger<CreateDeviceEventHandler> logger, IDevicesRepository devicesRepository,
        IUnitOfWorkManager uowManager, IDeviceTemplateRepository deviceTemplateRepository,
        IDeviceRunLogRepository deviceRunLogRepository)
    {
        _logger = logger;
        _devicesRepository = devicesRepository;
        _uowManager = uowManager;
        _deviceTemplateRepository = deviceTemplateRepository;
        _deviceRunLogRepository = deviceRunLogRepository;
    }

    /// <inheritdoc />
    public async Task HandleEventAsync(CreateDevicesEto eventData)
    {
        using var uow = _uowManager.Begin(new AbpUnitOfWorkOptions(), true);

        var device = await _devicesRepository.FirstOrDefaultAsync(x => x.Id == eventData.DeviceId);

        // 如果设备不存在将注册设备
        if (device == null)
        {
            // 获取设备模板
            var template = await _deviceTemplateRepository.FirstOrDefaultAsync(x => x.Id == eventData.DeviceTemplateId);

            if (template == null)
            {
                _logger.LogWarning("设备注册错误，未发现设备模板 数据记录 {CreateDevicesEto}", eventData);

                return;
            }

            device = new Device.Devices(eventData.DeviceId, template.Remark, DeviceStats.OnLine, null, template.Id);

            device = await _devicesRepository.InsertAsync(device);
        }

        await _deviceRunLogRepository.InsertAsync(new DeviceRunLog(Guid.NewGuid(), device.Id, eventData.Data));

        await uow.CompleteAsync();
    }
}
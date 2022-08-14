using Iot.Admin.Application.Contracts.Events;
using Iot.Devices;
using Iot.Events;
using Microsoft.Extensions.Logging;using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace Iot.Admin.Application.Events;

public class ICreateDeviceEvent : IDistributedEventHandler<CreateDevicesEto>, ITransientDependency
{
    private readonly IDevicesRepository _devicesRepository;
    private readonly IDHTLogsRepository _dhtLogsRepository;
    private readonly ILogger<ICreateDeviceEvent> _logger;

    public ICreateDeviceEvent(IDevicesRepository devicesRepository, ILogger<ICreateDeviceEvent> logger,
        IDHTLogsRepository dhtLogsRepository)
    {
        _devicesRepository = devicesRepository;
        _logger = logger;
        _dhtLogsRepository = dhtLogsRepository;
    }

    public async Task HandleEventAsync(CreateDevicesEto eventData)
    {
        var device = await _devicesRepository.FirstOrDefaultAsync(x => x.Id == eventData.DeviceId);

        if (device == null)
        {
            _logger.LogWarning("未找到{0} , 写入数据：{1}", eventData.DeviceId, eventData.Data);
        }

        switch (device.Type)
        {
            case DeviceType.DHT:
                await DHTxxx(eventData);
                break;
        }
    }

    /// <summary>
    /// 处理DHT日志
    /// </summary>
    /// <param name="data"></param>
    private async Task DHTxxx(CreateDevicesEto data)
    {
        var dto = data.Data as DHTDto;

        var dht = new DHTxxLogs(Guid.NewGuid(), data.DeviceId);
        dht.Logs.Add(nameof(dto.Humidity), dto.Humidity);
        dht.Logs.Add(nameof(dto.Temperature), dto.Humidity);
        await _dhtLogsRepository.InsertAsync(dht);
    }
}
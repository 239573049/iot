using Iot.Admin.Application.Contracts.Events;
using Iot.Devices;
using Iot.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Uow;

namespace Iot.Admin.Application.Events;

public class ICreateDeviceEvent : IDistributedEventHandler<CreateDevicesEto>, ITransientDependency
{
    private readonly ILogger<ICreateDeviceEvent> _logger;
    private readonly IUnitOfWorkManager _uowManager;
    private readonly IDevicesRepository _devicesRepository;
    private readonly IDHTLogsRepository _dhtLogsRepository;
    public ICreateDeviceEvent(ILogger<ICreateDeviceEvent> logger,  IDevicesRepository devicesRepository, IDHTLogsRepository dhtLogsRepository, IUnitOfWorkManager uowManager)
    {
        _logger = logger;
        _devicesRepository = devicesRepository;
        _dhtLogsRepository = dhtLogsRepository;
        _uowManager = uowManager;
    }

    public async Task HandleEventAsync(CreateDevicesEto eventData)
    {
        using var uow = _uowManager.Begin(new(), true);
        
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

        await uow.CompleteAsync();
    }

    /// <summary>
    /// 处理DHT日志
    /// </summary>
    /// <param name="data"></param>
    private async Task DHTxxx(CreateDevicesEto data)
    {
        var dto = JsonConvert.DeserializeObject<DHTDto>(data.Data.ToString());

        _logger.LogWarning("添加Dht日志 {data}", dto);
        var dht = new DHTxxLogs(Guid.NewGuid(), data.DeviceId);
        
        dht.Logs.Add(nameof(dto.Humidity), dto.Humidity);
        dht.Logs.Add(nameof(dto.Temperature), dto.Temperature);
        dht.IsDeleted = false;
        await _dhtLogsRepository.InsertAsync(dht);
    }
}
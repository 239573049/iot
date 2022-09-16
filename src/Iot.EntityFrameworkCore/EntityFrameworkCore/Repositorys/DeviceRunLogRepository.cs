using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iot.Device;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DeviceRunLogRepository : EfCoreRepository<IotDbContext, DeviceRunLog, Guid>, IDeviceRunLogRepository
{
    private readonly ITreeDeviceRepository _treeDeviceRepository;

    public DeviceRunLogRepository(IDbContextProvider<IotDbContext> dbContextProvider,
        ITreeDeviceRepository treeDeviceRepository) : base(dbContextProvider)
    {
        _treeDeviceRepository = treeDeviceRepository;
    }


    public async Task<List<DeviceRunLogView>> GetDeviceRunLogListAsync(string keywords, bool? device, Guid? deviceId,
        DateTime? startTime, DateTime? endTime,
        int skipCount, int maxResultCount)
    {
        var query = await CreateDeviceRunLogQueryAsync(device, keywords, deviceId, startTime, endTime);

        return await query.PageBy(skipCount, maxResultCount).ToListAsync();
    }

    public async Task<int> GetDeviceRunLogCountAsync(bool? device, string keywords, Guid? deviceId, DateTime? startTime,
        DateTime? endTime)
    {
        var query = await CreateDeviceRunLogQueryAsync(device, keywords, deviceId, startTime, endTime);

        return await query.CountAsync();
    }

    private async Task<IQueryable<DeviceRunLogView>> CreateDeviceRunLogQueryAsync(bool? isDevice, string keywords,
        Guid? deviceId, DateTime? startTime, DateTime? endTime)
    {
        var dbContext = await GetDbContextAsync();

        var deviceRunLogs = dbContext.DeviceRunLogs
            .WhereIf(deviceId.HasValue && isDevice == true, x => x.DeviceId == deviceId)
            .WhereIf(startTime.HasValue, x => x.CreationTime >= startTime)
            .WhereIf(endTime.HasValue, x => x.CreationTime <= endTime);

        List<Guid> ids = new List<Guid>();
        if (isDevice == false)
        {
            ids = await _treeDeviceRepository.GetTreeRecursionAsync(deviceId);
        }

        var query =
            from runLog in deviceRunLogs
            join device in dbContext.IotDevices on runLog.DeviceId equals device.Id
            join template in dbContext.DeviceTemplates on device.DeviceTemplateId equals template.Id
            where string.IsNullOrEmpty(keywords) || device.Name.Contains(keywords) ||
                  device.Remark.Contains(keywords) &&
                  (isDevice == false
                      ? ids.Contains((Guid)device.TreeId) || (deviceId == null)
                      : (deviceId != null && device.Id == deviceId))
            orderby runLog.CreationTime descending 
            select new DeviceRunLogView(runLog.Id, runLog.CreationTime, device.Name, device.Id, runLog.Logs)
            {
                Remark = device.Remark,
                Icon = template.Icon,
                Type = template.Type
            };

        return query;
    }
}
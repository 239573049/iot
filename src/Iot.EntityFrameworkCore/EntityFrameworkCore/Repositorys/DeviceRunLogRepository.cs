using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iot.Device;
using Iot.Devices;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DeviceRunLogRepository : EfCoreRepository<IotDbContext, DeviceRunLog, Guid>, IDeviceRunLogRepository
{
    public DeviceRunLogRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }


    public async Task<List<DeviceRunLogView>> GetDeviceRunLogListAsync(string keywords, Guid? deviceId,
        DateTime? startTime, DateTime? endTime,
        int skipCount, int maxResultCount)
    {
        var query = await CreateDeviceRunLogQueryAsync(keywords, deviceId, startTime, endTime);

        return await query.PageBy(skipCount, maxResultCount).ToListAsync();
    }

    public async Task<int> GetDeviceRunLogCountAsync(string keywords, Guid? deviceId, DateTime? startTime,
        DateTime? endTime)
    {
        var query = await CreateDeviceRunLogQueryAsync(keywords, deviceId, startTime, endTime);

        return await query.CountAsync();
    }

    private async Task<IQueryable<DeviceRunLogView>> CreateDeviceRunLogQueryAsync(string keywords,
        Guid? deviceId, DateTime? startTime, DateTime? endTime)
    {
        var dbContext = await GetDbContextAsync();

        var deviceRunLogs = dbContext.DeviceRunLogs.Where(x => x.DeviceId == deviceId)
            .WhereIf(startTime.HasValue, x => x.CreationTime >= startTime)
            .WhereIf(endTime.HasValue, x => x.CreationTime <= endTime);

        var query =
            from runLog in deviceRunLogs
            join device in dbContext.IotDevices on runLog.DeviceId equals device.Id
            where string.IsNullOrEmpty(keywords) || device.Name.Contains(keywords) || device.Remark.Contains(keywords)
            select new DeviceRunLogView(runLog.Id, runLog.CreationTime, device.Name,  device.Id, runLog.Logs);

        return query;
    }
}
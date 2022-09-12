using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Iot.Device;
using Iot.Devices;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Volo.Abp;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DevicesRepository : EfCoreRepository<IotDbContext, Device.Devices, Guid>, IDevicesRepository
{
    public DevicesRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<List<Device.Devices>> GetListAsync(Guid userId, string keywords, int skipCount,
        int maxResultCount)
    {
        var query = await CreateQueryAsync(userId, keywords);

        return await query.PageBy(skipCount, maxResultCount).ToListAsync();
    }


    private async Task<IQueryable<Device.Devices>> CreateQueryAsync(Guid userId, string keywords)
    {
        var dbContext = await GetDbContextAsync();

        var query = dbContext.IotDevices
            .Where(x => x.UserInfoId == userId)
            .WhereIf(!keywords.IsNullOrEmpty(),
                x => x.DeviceTemplate.Name.Contains(keywords) || x.Remark.Contains(keywords))
            .OrderByDescending(x => x.CreationTime);

        return query;
    }

    public async Task<List<DeviceView>> GetListAsync(string keywords, Guid userId, DeviceStats? stats=null, Guid? templateId=null,
        DateTime? startTime=null, DateTime? endTime=null, int skipCount=0,
        int maxResultCount = int.MaxValue)
    {
        var query = await CreateQueryAsync(keywords, stats, userId, templateId, startTime, endTime);

        return await query.PageBy(skipCount, maxResultCount).ToListAsync();
    }

    public async Task<int> GetCountAsync(string keywords, DeviceStats? stats, Guid userId, Guid? templateId,
        DateTime? startTime,
        DateTime? endTime)
    {
        var query = await CreateQueryAsync(keywords, stats, userId, templateId, startTime, endTime);

        return await query.CountAsync();
    }

    public async Task<DeviceHomeView> GetDeviceHomeAsync(Guid userId)
    {
        var dbContext = await GetDbContextAsync();

        var now = DateTime.Now;
        var home = new DeviceHomeView();

        var device = dbContext.IotDevices.Where(x => x.UserInfoId == userId);

        home.TemplateCount = await dbContext.DeviceTemplates.CountAsync(x => x.UserId == userId);
        home.DeviceCount = await device.CountAsync();

        var total = from runLog in dbContext.DeviceRunLogs
            join d in device on runLog.DeviceId equals d.Id
            select runLog;

        home.TotalCount = await total.CountAsync();
        home.TodayLogCount = await total
            .Where(x => x.CreationTime.Year == now.Year && x.CreationTime.Month == now.Month &&
                        x.CreationTime.Day == now.Day).CountAsync();

        return home;
    }

    private async Task<IQueryable<DeviceView>> CreateQueryAsync(string keywords, DeviceStats? stats, Guid userId,
        Guid? templateId,
        DateTime? startTime, DateTime? endTime)
    {
        var dbContext = await GetDbContextAsync();

        var devices = dbContext.IotDevices
            .AsSplitQuery()
            .WhereIf(!keywords.IsNullOrEmpty(), x => x.Name.Contains(keywords) || x.Remark.Contains(keywords))
            .WhereIf(templateId.HasValue, x => x.DeviceTemplateId == templateId)
            .Where(x => x.UserInfoId == userId)
            .WhereIf(startTime.HasValue, x => x.CreationTime >= startTime)
            .WhereIf(endTime.HasValue, x => x.CreationTime <= endTime)
            .WhereIf(stats.HasValue, x => x.Stats == stats);

        var query =
            from d in devices
            join template in dbContext.DeviceTemplates on d.DeviceTemplateId equals template.Id
            select new DeviceView(d.Id, d.Remark, d.Stats, d.Name, d.LastTime, d.UserInfoId, d.DeviceTemplateId,
                template.Icon, template.Type);

        return query;
    }
}
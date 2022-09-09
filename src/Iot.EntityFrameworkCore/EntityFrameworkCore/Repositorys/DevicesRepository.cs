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

    public async Task<int> GetCountAsync(Guid userId, string keywords)
    {
        var query = await CreateQueryAsync(userId, keywords);

        return await query.CountAsync();
    }

    public async Task<DeviceLogView> GetDeviceLogAsync(Guid deviceId)
    {
        var dbContext = await GetDbContextAsync();

        var device = await dbContext.IotDevices.Where(x => x.Id == deviceId).OrderByDescending(x => x.CreationTime)
            .FirstOrDefaultAsync();
        if (device == null)
        {
            throw new NoNullAllowedException("device");
        }


        throw new BusinessException(message: "未存在设备类型");
    }

    /// <inheritdoc />
    public async Task<List<DeviceLogView>> GetDeviceLogListAsync(Guid deviceId, DateTime? startTime, DateTime? endTime,
        int skipCount, int maxResultCount)
    {
        var query = await CreateLogAsync(deviceId, startTime, endTime);

        return await query.PageBy(skipCount, maxResultCount).ToListAsync();
    }

    /// <inheritdoc />
    public async Task<int> GetDeviceLogCountAsync(Guid deviceId, DateTime? startTime, DateTime? endTime)
    {
        var query = await CreateLogAsync(deviceId, startTime, endTime);

        return await query.CountAsync();
    }

    private async Task<IQueryable<DeviceLogView>> CreateLogAsync(Guid deviceId, DateTime? startTime, DateTime? endTime)
    {
        var dbContext = await GetDbContextAsync();

        var device = await dbContext.IotDevices.Where(x => x.Id == deviceId).OrderByDescending(x => x.CreationTime)
            .FirstOrDefaultAsync();
        if (device == null)
        {
            throw new NoNullAllowedException("device");
        }


        throw new BusinessException(message: "未存在设备类型");
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

    public async Task<List<DeviceView>> GetListAsync(string keywords, DeviceStats? stats, Guid userId, Guid? templateId,
        DateTime? startTime, DateTime? endTime, int skipCount,
        int maxResultCount)
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

    private async Task<IQueryable<DeviceView>> CreateQueryAsync(string keywords, DeviceStats? stats, Guid userId,
        Guid? templateId,
        DateTime? startTime, DateTime? endTime)
    {
        var dbContext = await GetDbContextAsync();

        var devices = dbContext.IotDevices
            .AsSplitQuery()
            .WhereIf(keywords.IsNullOrEmpty(), x => x.Name.Contains(keywords) || x.Remark.Contains(keywords))
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Iot.Devices;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Volo.Abp;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DevicesRepository : EfCoreRepository<IotDbContext, IotDevices, Guid>, IDevicesRepository
{
    public DevicesRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<List<IotDevices>> GetListAsync(Guid userId, string keywords, int skipCount, int maxResultCount)
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

        var device = await dbContext.IotDevices.FirstOrDefaultAsync(x => x.Id == deviceId);
        if (device == null)
        {
            throw new NoNullAllowedException("device");
        }

        switch (device.Type)
        {
            case DeviceType.DHT:
                return await CreateDHTxxAsync(dbContext,deviceId);
                break;
        }

        throw new BusinessException(message: "未存在设备类型");
    }

    /// <summary>
    /// 创建查询DHT日志
    /// </summary>
    /// <param name="dbContext"></param>
    /// <param name="deviceId"></param>
    /// <returns></returns>
    private async Task<DeviceLogView> CreateDHTxxAsync(IotDbContext dbContext, Guid deviceId)
    {
        var query = await dbContext.DhTxxLogs.Where(x => x.DeviceId == deviceId)
            .OrderByDescending(x => x.CreationTime).Select(x => new DeviceLogView
            {
                Id = x.Id,
                Type = DeviceType.DHT,
                CreationTime = x.CreationTime,
                Data = JsonConvert.SerializeObject(x.Logs)
            })
            .FirstOrDefaultAsync();

        return query;
    }

    private async Task<IQueryable<IotDevices>> CreateQueryAsync(Guid userId, string keywords)
    {
        var dbContext = await GetDbContextAsync();

        var query = dbContext.IotDevices
            .Where(x => x.UserInfoId == userId)
            .WhereIf(!keywords.IsNullOrEmpty(), x => x.Name.Contains(keywords) || x.Remark.Contains(keywords))
            .OrderByDescending(x => x.CreationTime);

        return query;
    }
}
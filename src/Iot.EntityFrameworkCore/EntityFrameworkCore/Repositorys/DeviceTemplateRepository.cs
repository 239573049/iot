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

public class DeviceTemplateRepository : EfCoreRepository<IotDbContext, DeviceTemplate, Guid>, IDeviceTemplateRepository
{
    public DeviceTemplateRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<List<DeviceTemplate>> GetListAsync(string keywords, Guid userId, DateTime? startTime, DateTime? endTime,
        int skipCount, int maxResultCount)
    {
        var query = await CreateQueryAsync(keywords, userId, startTime, endTime);

        return await query.ToListAsync();
    }

    public async Task<int> GetCountAsync(string keywords, Guid userId, DateTime? startTime, DateTime? endTime)
    {
        var query = await CreateQueryAsync(keywords, userId, startTime, endTime);

        return await query.CountAsync();
    }

    private async Task<IQueryable<DeviceTemplate>> CreateQueryAsync(string keywords, Guid userId, DateTime? startTime,
        DateTime? endTime)
    {
        var dbContext = await GetDbContextAsync();

        var query = dbContext.DeviceTemplates.Where(x => x.UserId == null || x.UserId == userId)
            .WhereIf(!keywords.IsNullOrEmpty(), x => x.Name.Contains(keywords) || x.Remark.Contains(keywords))
            .WhereIf(startTime.HasValue, x => x.CreationTime >= startTime)
            .WhereIf(endTime.HasValue, x => x.CreationTime <= endTime);

        return query;
    }
}
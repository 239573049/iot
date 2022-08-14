using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iot.Devices;
using Microsoft.EntityFrameworkCore;
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

    private async Task<IQueryable<IotDevices>> CreateQueryAsync(Guid userId, string keywords)
    {
        var dbContext = await GetDbContextAsync();

        var query = dbContext.IotDevices
            .Where(x => x.UserInfoId == userId)
            .WhereIf(!keywords.IsNullOrEmpty(), x => x.Name.Contains(keywords) || x.Remark.Contains(keywords));

        return query;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iot.Device;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class TreeDeviceRepository : EfCoreRepository<IotDbContext, TreeDevice, Guid>, ITreeDeviceRepository
{
    public TreeDeviceRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<List<Guid>> GetTreeRecursionAsync(Guid? treeId = null)
    {
        var dbContext = await GetDbContextAsync();

        var trees = await dbContext.TreeDevices.ToListAsync();

        var ids = GetRecursion(trees, treeId);

        return ids;
    }

    private List<Guid> GetRecursion(List<TreeDevice> treeDevices,Guid? treeId) 
    {
        var ids = new List<Guid>();

        var treeDevice = treeDevices.Where(x => x.ParentId == treeId);
        treeDevices = treeDevices.Where(x => x.ParentId != treeId).ToList();

        foreach (var t in treeDevice)
        {
            ids.Add(t.Id);
            ids.AddRange(GetRecursion(treeDevices,t.Id));
        }

        return ids;
    }
}
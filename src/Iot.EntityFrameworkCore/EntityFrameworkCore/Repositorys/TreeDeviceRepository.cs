using System;
using Iot.Device;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class TreeDeviceRepository : EfCoreRepository<IotDbContext, TreeDevice, Guid>, ITreeDeviceRepository
{
    public TreeDeviceRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
using System;
using Iot.Devices;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DevicesRepository : EfCoreRepository<IotDbContext, IotDevices, Guid>, IDevicesRepository
{
    public DevicesRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
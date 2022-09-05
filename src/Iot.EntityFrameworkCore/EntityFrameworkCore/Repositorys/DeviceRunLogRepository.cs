using System;
using Iot.Device;
using Iot.Devices;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DeviceRunLogRepository : EfCoreRepository<IotDbContext, DeviceRunLog, Guid>, IDeviceRunLogRepository
{
    public DeviceRunLogRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    
    
}
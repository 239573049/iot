using System;
using Iot.Devices;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class DHTLogsRepository : EfCoreRepository<IotDbContext, DHTxxLogs, Guid>, IDHTLogsRepository
{
    public DHTLogsRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
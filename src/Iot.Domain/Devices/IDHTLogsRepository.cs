using System;
using Volo.Abp.Domain.Repositories;

namespace Iot.Devices;

public interface IDHTLogsRepository : IRepository<DHTxxLogs,Guid>
{
    
}
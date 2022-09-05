using System;
using Iot.Devices;
using Volo.Abp.Domain.Repositories;

namespace Iot.Device;

public interface IDeviceRunLogRepository : IRepository<DeviceRunLog,Guid>
{
    
}
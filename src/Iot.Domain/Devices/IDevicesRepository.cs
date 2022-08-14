using System;
using Volo.Abp.Domain.Repositories;

namespace Iot.Devices;

public interface IDevicesRepository : IRepository<IotDevices,Guid>
{
    
}
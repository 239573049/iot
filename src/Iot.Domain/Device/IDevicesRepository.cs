using System;
using Volo.Abp.Domain.Repositories;

namespace Iot.Device;

public interface IDevicesRepository : IRepository<Device.Devices, Guid>
{
}
using System;
using Volo.Abp.Domain.Repositories;

namespace Iot.Device;

public interface ITreeDeviceRepository : IRepository<TreeDevice,Guid>
{
    
}
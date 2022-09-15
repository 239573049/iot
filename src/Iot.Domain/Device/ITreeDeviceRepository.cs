using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Iot.Device;

public interface ITreeDeviceRepository : IRepository<TreeDevice,Guid>
{
    Task<List<Guid>> GetTreeRecursionAsync(Guid? treeId=null);
}
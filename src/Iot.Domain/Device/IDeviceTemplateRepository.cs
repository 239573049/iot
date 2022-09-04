using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Iot.Devices;
using Volo.Abp.Domain.Repositories;

namespace Iot.Device;

public interface IDeviceTemplateRepository : IRepository<DeviceTemplate,Guid>
{
    /// <summary>
    /// 获取列表
    /// </summary>
    /// <param name="keywords"></param>
    /// <param name="userId"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <param name="skipCount"></param>
    /// <param name="maxResultCount"></param>
    /// <returns></returns>
    Task<List<DeviceTemplate>> GetListAsync(string keywords, Guid userId, DateTime? startTime, DateTime? endTime,
        int skipCount, int maxResultCount);

    /// <summary>
    /// 获取条数
    /// </summary>
    /// <param name="keywords"></param>
    /// <param name="userId"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <returns></returns>
    Task<int> GetCountAsync(string keywords, Guid userId, DateTime? startTime, DateTime? endTime);
}
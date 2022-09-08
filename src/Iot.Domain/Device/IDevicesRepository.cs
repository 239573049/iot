using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Iot.Device;

public interface IDevicesRepository : IRepository<Device.Devices, Guid>
{
    /// <summary>
    /// 获取设备数据
    /// </summary>
    /// <param name="keywords"></param>
    /// <param name="stats"></param>
    /// <param name="userId"></param>
    /// <param name="templateId"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <param name="skipCount"></param>
    /// <param name="maxResultCount"></param>
    /// <returns></returns>
    Task<List<Devices>> GetListAsync(string keywords, DeviceStats? stats, Guid userId, Guid? templateId,
        DateTime? startTime,
        DateTime? endTime,
        int skipCount, int maxResultCount);

    /// <summary>
    /// 获取设备总条数
    /// </summary>
    /// <param name="keywords"></param>
    /// <param name="stats"></param>
    /// <param name="userId"></param>
    /// <param name="templateId"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <returns></returns>
    Task<int> GetCountAsync(string keywords, DeviceStats? stats, Guid userId, Guid? templateId, DateTime? startTime,
        DateTime? endTime);
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iot.Devices;
using Volo.Abp.Domain.Repositories;

namespace Iot.Device;

public interface IDeviceRunLogRepository : IRepository<DeviceRunLog, Guid>
{
    /// <summary>
    /// 设备列表
    /// </summary>
    /// <returns></returns>
    Task<List<DeviceRunLogView>> GetDeviceRunLogListAsync(string keywords, bool? device, Guid? deviceId,
        DateTime? startTime,
        DateTime? endTime,
        int skipCount, int maxResultCount);

    /// <summary>
    /// 设备总数
    /// </summary>
    /// <returns></returns>
    Task<int> GetDeviceRunLogCountAsync(bool? device, string keywords, Guid? deviceId,
        DateTime? startTime,
        DateTime? endTime);

    /// <summary>
    /// 获取IQueryable
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <returns></returns>
    Task<IQueryable<DeviceRunLog>> GetQueryAsync(Guid? userId, DateTime? startTime,
        DateTime? endTime);
}
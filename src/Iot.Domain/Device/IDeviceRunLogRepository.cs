using System;
using System.Collections.Generic;
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
}
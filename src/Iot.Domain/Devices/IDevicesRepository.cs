using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Iot.Devices;

public interface IDevicesRepository : IRepository<IotDevices, Guid>
{
    /// <summary>
    /// 获取设备列表
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="keywords"></param>
    /// <param name="skipCount"></param>
    /// <param name="maxResultCount"></param>
    /// <returns></returns>
    Task<List<IotDevices>> GetListAsync(Guid userId, string keywords, int skipCount, int maxResultCount);

    /// <summary>
    /// 获取设备列表数量
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="keywords"></param>
    /// <returns></returns>
    Task<int> GetCountAsync(Guid userId, string keywords);

    /// <summary>
    /// 获取设备最近运行信息
    /// </summary>
    /// <param name="deviceId"></param>
    /// <returns></returns>
    Task<DeviceLogView> GetDeviceLogAsync(Guid deviceId);
}
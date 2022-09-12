using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Iot.EntityFrameworkCore.Repositorys;
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
    Task<List<DeviceView>> GetListAsync(string keywords, Guid userId, DeviceStats? stats, Guid? templateId,
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

    /// <summary>
    /// 获取用户基本设备数量
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<DeviceHomeView> GetDeviceHomeAsync(Guid userId);
}
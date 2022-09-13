using Iot.Admin.Application.Contracts.Devices.Views;

namespace Iot.Admin.Application.Contracts.Devices;

/// <summary>
/// 设备树形模块
/// </summary>
public interface ITreeDeviceService
{
    /// <summary>
    /// 创建树形文件夹
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task CreateAsync(TreeDeviceInput input);

    /// <summary>
    /// 编辑设备树形
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task UpdateAsync(TreeDeviceInput input);

    /// <summary>
    /// 删除设备树形
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// 获取树形结构
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<List<TreeDeviceDto>> GetTreeAsync(GetTreeDeviceInput input);

    /// <summary>
    /// 修改绑定的父级
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task UpdateParentAsync(UpdateParentInput input);
}
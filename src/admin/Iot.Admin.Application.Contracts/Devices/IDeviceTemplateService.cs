using Iot.Admin.Application.Contracts.Devices.Views;
using Volo.Abp.Application.Dtos;

namespace Iot.Admin.Application.Contracts.Devices;

/// <summary>
/// 模板
/// </summary>
public interface IDeviceTemplateService
{
    /// <summary>
    /// 创建模板
    /// </summary>
    /// <param name="deviceTemplate"></param>
    /// <returns></returns>
    Task CreateAsync(CreateDeviceTemplate deviceTemplate);

    /// <summary>
    /// 删除模板
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// 获取模板列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<PagedResultDto<DeviceTemplateDto>> GetListAsync(GetDeviceTemplateInput input);

    /// <summary>
    /// 编辑模块
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task UpdateAsync(DeviceTemplateDto dto);

    /// <summary>
    /// 获取所有模板
    /// </summary>
    /// <param name="keywords"></param>
    /// <returns></returns>
    Task<List<DeviceTemplateDto>> GetAllAsync(string keywords);
}
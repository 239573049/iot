using Iot.Auth.Application.Contracts.Menu.Views;

namespace Iot.Auth.Application.Contracts.Menu;

public interface IMenuService
{
    /// <summary>
    /// 角色菜单树形结构
    /// </summary>
    /// <returns></returns>
    Task<List<MenuDto>> GetRoleMenuAsync();

    /// <summary>
    /// 获取菜单树形结构
    /// </summary>
    /// <returns></returns>
    Task<List<MenuTreeDto>> GetMenuTreeAsync();

    /// <summary>
    /// 更新节点
    /// </summary>
    /// <returns></returns>
    Task UpdateMenuParentIdAsync(Guid id,UpdateMenuParentIdInput input);
}
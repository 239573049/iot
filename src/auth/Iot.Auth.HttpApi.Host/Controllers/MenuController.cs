using Iot.Auth.Application.Contracts.Menu;
using Iot.Auth.Application.Contracts.Menu.Views;
using Microsoft.AspNetCore.Mvc;

namespace Iot.Auth.HttpApi.Host.Controllers;

/// <summary>
/// 权限菜单管理
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    private readonly IMenuService _menuService;

    /// <inheritdoc />
    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    /// <summary>
    /// 角色菜单树形结构
    /// </summary>
    /// <returns></returns>
    [HttpGet("role-menu")]
    public  async Task<List<MenuDto>> RoleMenuAsync() =>
        await _menuService.GetRoleMenuAsync();

    /// <summary>
    /// 获取菜单树形结构
    /// </summary>
    /// <returns></returns>
    [HttpGet("menu-tree")]
    public  async Task<List<MenuTreeDto>> MenuTreeAsync() =>
        await _menuService.GetMenuTreeAsync();

    /// <summary>
    /// 更新节点
    /// </summary>
    /// <returns></returns>
    [HttpPut("menu-parent/{id}")]
    public async Task MenuParentIdAsync(Guid id, [FromBody] UpdateMenuParentIdInput input) =>
        await _menuService.UpdateMenuParentIdAsync(id, input);
}
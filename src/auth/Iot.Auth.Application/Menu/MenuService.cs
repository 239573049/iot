using Iot.Auth.Application.Contracts.Menu;
using Iot.Auth.Application.Contracts.Menu.Views;
using Iot.Auth.Domain.Roles;
using Iot.Common.Jwt;
using Volo.Abp.Application.Services;

namespace Iot.Auth.Application.Menu;

public class MenuService : ApplicationService, IMenuService
{
    private readonly IMenuRepository _menuRepository;
    private readonly Accessor _accessor;

    public MenuService(IMenuRepository menuRepository, Accessor accessor)
    {
        _menuRepository = menuRepository;
        _accessor = accessor;
    }

    /// <inheritdoc />
    public async Task<List<MenuDto>> GetRoleMenuAsync()
    {
        var roleIds = _accessor.GetRoleIds();
        
        var menus =await _menuRepository.GetRoleMenusAsync(roleIds);

        var result = GetRoleMenuTree(menus, null);

        return result;
    }

    /// <inheritdoc />
    public async Task<List<MenuTreeDto>> GetMenuTreeAsync()
    {
        var tree = await _menuRepository.GetListAsync();

        var result = GetMenuTree(tree, null);

        return result;
    }

    private List<MenuTreeDto> GetMenuTree(List<Domain.Roles.Menu> menus,Guid? parentId)
    {
        var result = new List<MenuTreeDto>();
        
        var data = menus.Where(x => parentId == null ? x.ParentId == null : x.ParentId == parentId)
            .OrderBy(x=>x.Index);
        
        menus = menus.Where(x => parentId == null ? x.ParentId != null : x.ParentId != parentId).ToList();
        
        foreach (var d in data)
        {
            var dto = new MenuTreeDto()
            {
                Key = d.Id,
                Icon = d.Icon,
                Title = d.Title,
                Name = d.Name,
                Path = d.Path,
                ParentId = d.ParentId,
                Component = d.Component
                
            };
            dto.Children.AddRange(GetMenuTree(menus, d.Id));
            result.Add(dto);
        }

        return result;
        
    }
    
    /// <summary>
    /// 递归获取菜单树形结构
    /// </summary>
    /// <param name="menus"></param>
    /// <param name="parentId"></param>
    /// <returns></returns>
    private List<MenuDto> GetRoleMenuTree(List<Domain.Roles.Menu> menus,Guid? parentId)
    {
        var result = new List<MenuDto>();

        var data = menus.Where(x => parentId == null ? x.ParentId == null : x.ParentId == parentId)
            .OrderBy(x=>x.Index);

        menus = menus.Where(x => parentId == null ? x.ParentId != null : x.ParentId != parentId).ToList();

        foreach (var d in data)
        {
            var dto = ObjectMapper.Map<Domain.Roles.Menu, MenuDto>(d);
            dto.Routes.AddRange(GetRoleMenuTree(menus, d.Id));
            result.Add(dto);
        }

        return result;
    }
}
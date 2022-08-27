using Volo.Abp.Domain.Repositories;

namespace Iot.Auth.Domain.Roles;

public interface IMenuRepository : IRepository<Menu,Guid>
{
    /// <summary>
    /// 获取角色相应的菜单权限
    /// </summary>
    /// <param name="roleId"></param>
    /// <returns></returns>
    Task<List<Menu>> GetRoleMenusAsync(List<Guid> roleId);
}
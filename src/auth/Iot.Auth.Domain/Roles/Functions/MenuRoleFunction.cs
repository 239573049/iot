using Volo.Abp.Domain.Entities;

namespace Iot.Auth.Domain.Roles.Functions;

public class MenuRoleFunction 
{
    /// <summary>
    ///
    /// </summary>
    public Guid MenuId { get; set; }

    /// <summary>
    ///
    /// </summary>
    public Guid RoleId { get; set; }

    /// <summary>
    ///
    /// </summary>
    public virtual Menu? Menu { get; set; }

    /// <summary>
    ///
    /// </summary>
    public virtual Role? Role { get; set; }

    public MenuRoleFunction(Guid menuId, Guid roleId)
    {
        MenuId = menuId;
        RoleId = roleId;
    }

    public MenuRoleFunction()
    {
    }
}
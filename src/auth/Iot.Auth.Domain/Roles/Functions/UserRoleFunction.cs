using Iot.Users;
using Volo.Abp.Domain.Entities;

namespace Iot.Auth.Domain.Roles.Functions;

public class UserRoleFunction 
{
    public Guid UserInfoId { get; set; }

    public Guid RoleId { get; set; }

    public virtual Role Role { get; set; }

    public UserRoleFunction()
    {
    }

    public UserRoleFunction(Guid userInfoId, Guid roleId)
    {
        UserInfoId = userInfoId;
        RoleId = roleId;
    }
}
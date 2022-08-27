using Iot.Users;
using Volo.Abp.Domain.Entities;

namespace Iot.Auth.Domain.Roles.Functions;

public class UserRoleFunction : AggregateRoot<Guid>
{
    public Guid UserInfoId { get; set; }

    public Guid RoleId { get; set; }

    public virtual UserInfo UserInfo { get; set; }

    public virtual Role Role { get; set; }
}
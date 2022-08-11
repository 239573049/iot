using Volo.Abp.Domain.Entities;

namespace Iot.Auth.Domain.Roles;

public class Role : AggregateRoot<Guid>
{
    public string? Name { get; protected set; }

    public int Index { get; protected set; }
}
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Iot.Auth.Domain.Roles;

public class Role : AggregateRoot<Guid>, ISoftDelete, IHasCreationTime
{
    /// <summary>
    ///     名称
    /// </summary>
    public string? Name { get; protected set; }

    /// <summary>
    ///     编号
    /// </summary>
    public string? Code { get; protected set; }

    /// <summary>
    ///     备注
    /// </summary>
    public string? Remark { get; protected set; }

    /// <summary>
    ///     排序
    /// </summary>
    public int Index { get; protected set; }

    /// <summary>
    ///     父级
    /// </summary>
    public Guid? ParentId { get; protected set; }

    public bool IsDeleted { get; set; }

    public DateTime CreationTime { get; protected set; }

    public Role()
    {
    }

    public Role(Guid id, string? name, string? code, string? remark, int index, Guid? parentId, bool isDeleted,
        DateTime creationTime) : base(id)
    {
        Name = name;
        Code = code;
        Remark = remark;
        Index = index;
        ParentId = parentId;
        IsDeleted = isDeleted;
        CreationTime = creationTime;
    }
}
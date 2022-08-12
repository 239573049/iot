using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Iot.Auth.Domain.Roles;

public class Menu : AggregateRoot<Guid>,ISoftDelete,IHasCreationTime
{
    
    public int Index { get; set; }

    /// <summary>
    /// </summary>
    public string? Component { get; set; }

    /// <summary>
    ///     标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    ///     名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     图标
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    ///     路由
    /// </summary>
    public string? Path { get; set; }

    /// <summary>
    ///     父级id
    /// </summary>
    public Guid? ParentId { get; set; }

    public bool IsDeleted { get; set; }
    
    public DateTime CreationTime { get; }
}
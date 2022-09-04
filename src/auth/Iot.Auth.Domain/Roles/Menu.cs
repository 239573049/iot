using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Iot.Auth.Domain.Roles;

public class Menu : AggregateRoot<Guid>,ISoftDelete,IHasCreationTime
{
    
    public int Index { get; set; }

    /// <summary>
    /// 组件
    /// </summary>
    public string? Component { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 路由
    /// </summary>
    public string? Path { get; set; }

    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; set; }

    public bool IsDeleted { get; set; }
    
    public DateTime CreationTime { get; }

    public Menu()
    {
    }

    public Menu(Guid id, int index, string? component, string? title, string? name, string? icon, string? path, Guid? parentId) : base(id)
    {
        Index = index;
        Component = component;
        Title = title;
        Name = name;
        Icon = icon;
        Path = path;
        ParentId = parentId;
        IsDeleted = false;
        CreationTime = DateTime.Now;
    }
}
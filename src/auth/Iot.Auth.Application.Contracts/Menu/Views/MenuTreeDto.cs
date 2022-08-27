namespace Iot.Auth.Application.Contracts.Menu.Views;

public class MenuTreeDto
{
    /// <summary>
    /// 主键
    /// </summary>
    public Guid Key { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string? Icon { get; set; }

    public int Index { get; set; }

    /// <summary>
    /// 组件
    /// </summary>
    public string? Component { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 路由
    /// </summary>
    public string? Path { get; set; }

    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; set; }
    
    /// <summary>
    /// 子集
    /// </summary>
    public List<MenuTreeDto> Children { get; set; } = new();
}
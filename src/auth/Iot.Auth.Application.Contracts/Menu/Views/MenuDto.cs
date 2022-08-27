namespace Iot.Auth.Application.Contracts.Menu.Views;

public class MenuDto
{
    public Guid Id { get; set; }

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


    public DateTime CreationTime { get; }

    public List<MenuDto> Routes { get; set; } = new();
}
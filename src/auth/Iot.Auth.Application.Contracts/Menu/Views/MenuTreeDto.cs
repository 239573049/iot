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

    /// <summary>
    /// 子集
    /// </summary>
    public List<MenuTreeDto> Children { get; set; } = new();
}
using Volo.Abp.Application.Dtos;

namespace Iot.Admin.Application.Contracts.Devices.Views;

/// <summary>
/// 树形结构模型
/// </summary>
public class TreeDeviceDto 
{
    public Guid Key { get; set; }
    
    /// <summary>
    /// 标题
    /// </summary>
    public string? Title { get; }

    /// <summary>
    /// 图标
    /// </summary>
    public string? Icon { get; }

    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; }

    /// <summary>
    /// 是否子节点
    /// </summary>
    public bool IsLeaf { get; }

    public List<TreeDeviceDto> Children { get; }

    /// <inheritdoc />
    public TreeDeviceDto()
    {
        Children = new List<TreeDeviceDto>();
    }

    /// <inheritdoc />
    public TreeDeviceDto(Guid key,string? title, string? icon, Guid? parentId, bool isLeaf = false)
    {
        Key = key;
        Title = title;
        Icon = icon;
        IsLeaf = isLeaf;
        ParentId = parentId;
        Children = new List<TreeDeviceDto>();
    }
}
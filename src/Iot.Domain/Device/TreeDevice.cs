using System;

namespace Iot.Device;

public class TreeDevice : IotAggregateRoot<Guid>
{
    public string Title { get; set; }

    public string Icon { get; set; }

    /// <summary>
    /// 绑定用户
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; set; }
}
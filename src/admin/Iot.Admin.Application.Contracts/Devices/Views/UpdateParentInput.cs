namespace Iot.Admin.Application.Contracts.Devices.Views;

public class UpdateParentInput
{
    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// 是否设备
    /// </summary>
    public bool Device { get; set; }

    public Guid Id { get; set; }
}
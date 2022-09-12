namespace Iot.Admin.Application.Contracts.Devices.Views;

public class GetTreeDeviceInput : IotInput
{
    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; set; }
}
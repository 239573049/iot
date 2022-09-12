namespace Iot.Admin.Application.Contracts.Devices.Views;

public class CreateDeviceTemplate
{
    /// <summary>
    /// 设备名称
    /// </summary>
    public string Name { get;  set; }

    /// <summary>
    /// 设备图标
    /// </summary>
    public string Icon { get;  set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public string Type { get;  set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get;  set; }
}
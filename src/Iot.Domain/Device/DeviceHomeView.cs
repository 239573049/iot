namespace Iot.Device;

public class DeviceHomeView
{
    /// <summary>
    /// 用户设备数量
    /// </summary>
    public int DeviceCount { get; set; }

    /// <summary>
    /// 今天产生日志数量
    /// </summary>
    public int TodayLogCount { get; set; }

    /// <summary>
    /// 所有运行日志数量
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 用户模板数量
    /// </summary>
    public int TemplateCount { get; set; }
}
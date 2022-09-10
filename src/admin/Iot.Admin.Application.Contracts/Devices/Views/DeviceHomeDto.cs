namespace Iot.Admin.Application.Contracts.Devices.Views;

/// <summary>
/// 首页展示数据
/// </summary>
public class DeviceHomeDto
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
}
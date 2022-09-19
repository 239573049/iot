namespace Iot.Admin.Application.Contracts.Home.DeviceView;

/// <summary>
/// 设备日志图标展示模型
/// </summary>
public class DeviceDateLogDto
{
    /// <summary>
    /// 图标时间间隔
    /// </summary>
    public List<string> Date { get; set; }

    public List<Series> Series { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DeviceDateLogDto()
    {
        Date = new List<string>();
        Series = new List<Series>();
    }
}

public class Series
{
    /// <summary>
    /// 图表显示名称
    /// </summary>
    public string? Name { get; } 

    /// <summary>
    /// 图标显示类型
    /// </summary>
    public string? Type { get; }

    /// <summary>
    /// 图标数据
    /// </summary>
    public List<int> Data { get; }

    public Series()
    {
        Name = "运行日志";
        Type = "line";
        Data = new List<int>();
    }
}
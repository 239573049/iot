using System.ComponentModel;

namespace Iot;

public enum DeviceStats
{
    /// <summary>
    /// 在线
    /// </summary>
    [Description("在线")]
    OnLine = 0,

    /// <summary>
    /// 离线
    /// </summary>
    [Description("离线")]
    OffLine,

    /// <summary>
    /// 异常
    /// </summary>
    [Description("异常")]
    Abnormal
    
}
using System.ComponentModel;

namespace Iot;

public enum DeviceType
{
    /// <summary>
    /// DHTxx温度计
    /// </summary>
    [Description("DHTxx温度计")]
    DHT,
}
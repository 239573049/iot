namespace Iot.Admin.Application.Contracts.Events;

public class DHTDto
{
    /// <summary>
    /// 温度
    /// </summary>
    public string? Temperature { get; set; }

    /// <summary>
    /// 湿度
    /// </summary>
    public string? Humidity { get; set; }
}
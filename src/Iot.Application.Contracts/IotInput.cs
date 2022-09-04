using System;

namespace Iot;

public class IotInput : PagedRequestDto
{
    /// <summary>
    /// 关键字
    /// </summary>
    public string Keywords { get; set; }
    
    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}
using Volo.Abp.Application.Dtos;

namespace Iot.Admin.Application.Contracts.Devices.Views;

public class DeviceRunLogDto : EntityDto<Guid>
{ 
    
    /// <summary>
    /// 设备名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 设备编号
    /// </summary>
    public Guid DeviceId { get;  set; }

    /// <summary>
    /// 运行信息
    /// </summary>
    public Dictionary<string, object> Logs { get;  set; }

    /// <summary>
    /// 创建时间
    /// </summary>

    public DateTime CreationTime { get;  set; }
}
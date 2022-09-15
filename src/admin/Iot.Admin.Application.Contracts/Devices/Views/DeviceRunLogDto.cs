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
    public string Logs { get;  set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public string Type { get;  set; }
    
    /// <summary>
    /// 设备图标
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get;  set; }
    
    /// <summary>
    /// 创建时间
    /// </summary>

    public DateTime CreationTime { get;  set; }
}
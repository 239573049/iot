using System.Text.Json;
using AutoMapper;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Device;
using Newtonsoft.Json;

namespace Iot.Admin.Application.AutoMapper;

/// <summary>
/// 设备运行日志map配置
/// </summary>
public class DevicesRunLogAutoMapperProfile : Profile
{
    /// <inheritdoc />
    public DevicesRunLogAutoMapperProfile()
    {
        CreateMap<DeviceRunLogView, DeviceRunLogDto>()
            .ForMember(x => x.Logs, x => x.MapFrom(a => JsonConvert.SerializeObject(a.Logs)));
    }
}
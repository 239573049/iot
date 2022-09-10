using AutoMapper;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Device;

namespace Iot.Admin.Application.AutoMapper;

/// <summary>
/// 设备运行日志map配置
/// </summary>
public class DevicesRunLogAutoMapperProfile : Profile
{
    /// <inheritdoc />
    public DevicesRunLogAutoMapperProfile()
    {
        CreateMap<DeviceRunLogView, DeviceRunLogDto>();
    }
}
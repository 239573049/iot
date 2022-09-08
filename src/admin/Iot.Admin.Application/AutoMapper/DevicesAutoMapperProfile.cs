using AutoMapper;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Common.Core.Extensions;
using Iot.Devices;

namespace Iot.Admin.Application.AutoMapper;

public class DevicesAutoMapperProfile : Profile
{
    public DevicesAutoMapperProfile()
    {
        CreateMap<IotDevicesDto, Device.Devices>();
        CreateMap<Device.Devices, DeviceDto>()
            .ForMember(x => x.Stats, opt => opt.MapFrom(x => x.Stats.GetDescription()));
        CreateMap<Device.Devices, IotDevicesDto>();
        CreateMap<DeviceLogView, DeviceLogDto>();

        CreateMap<CreateDeviceTemplate, DeviceTemplate>();
        CreateMap<DeviceTemplate, DeviceTemplateDto>();
        CreateMap<DeviceTemplateDto, DeviceTemplate>();
    }
}
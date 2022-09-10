using AutoMapper;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Common.Core.Extensions;
using Iot.Device;
using Iot.Devices;
using Iot.EntityFrameworkCore.Repositorys;

namespace Iot.Admin.Application.AutoMapper;

public class DevicesAutoMapperProfile : Profile
{
    public DevicesAutoMapperProfile()
    {
        CreateMap<IotDevicesDto, Device.Devices>();
        CreateMap<Device.Devices, DeviceDto>()
            .ForMember(x => x.Stats, opt => opt.MapFrom(x => x.Stats.GetDescription()));
        CreateMap<Device.Devices, IotDevicesDto>();
        CreateMap<CreateDeviceInput, Device.Devices>();
        CreateMap<DeviceView, DeviceDto>()
            .ForMember(x => x.Stats, opt => opt.MapFrom(x => x.Stats.GetDescription()));

        CreateMap<DeviceHomeView, DeviceHomeDto>();
        CreateMap<CreateDeviceTemplate, DeviceTemplate>();
        CreateMap<DeviceTemplate, DeviceTemplateDto>();
        CreateMap<DeviceTemplateDto, DeviceTemplate>();
    }
}
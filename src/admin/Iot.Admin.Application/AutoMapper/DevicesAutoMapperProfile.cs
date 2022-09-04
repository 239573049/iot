using AutoMapper;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Devices;

namespace Iot.Admin.Application.AutoMapper;

public class DevicesAutoMapperProfile : Profile
{
    public DevicesAutoMapperProfile()
    {
        CreateMap<CreateDeviceInput, Device.Devices>();
        CreateMap<IotDevicesDto, Device.Devices>();
        CreateMap<Device.Devices,IotDevicesDto>();
        CreateMap<DeviceLogView,DeviceLogDto>();

        CreateMap<CreateDeviceTemplate, DeviceTemplate>();
        CreateMap<DeviceTemplate, DeviceTemplateDto>();
    }
}
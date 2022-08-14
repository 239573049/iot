using AutoMapper;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Devices;

namespace Iot.Admin.Application.AutoMapper;

public class DevicesAutoMapperProfile : Profile
{
    public DevicesAutoMapperProfile()
    {
        CreateMap<CreateDeviceInput, IotDevices>();
    }
}
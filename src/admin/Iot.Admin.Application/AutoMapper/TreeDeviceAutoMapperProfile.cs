using AutoMapper;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Device;

namespace Iot.Admin.Application.AutoMapper;

public class TreeDeviceAutoMapperProfile : Profile
{
    public TreeDeviceAutoMapperProfile()
    {
        CreateMap<TreeDeviceInput, TreeDevice>();
    }
}
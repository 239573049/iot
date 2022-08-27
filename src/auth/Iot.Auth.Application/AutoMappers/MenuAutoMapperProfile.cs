using AutoMapper;
using Iot.Auth.Application.Contracts.Menu.Views;

namespace Iot.Auth.Application.AutoMappers;

public class MenuAutoMapperProfile : Profile
{
    public MenuAutoMapperProfile()
    {
        CreateMap<MenuDto, Domain.Roles.Menu>().ReverseMap();
    }
}
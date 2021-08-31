using AutoMapper;
using Bangalore.API.Models;
using Bangalores.CORE.Dtos;

namespace Bangalore.API.Profiles
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Users, UserDto>().ReverseMap();
        }
    }
}
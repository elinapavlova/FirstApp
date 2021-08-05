using AutoMapper;
using Models.User;

namespace Infrastructure.Profiles
{
    public class AppProfile : Profile
    {
        public AppProfile ()
        {
            CreateMap<UserRequestDto, User>();
            CreateMap<User, UserResponseDto>();
        }
    }
}
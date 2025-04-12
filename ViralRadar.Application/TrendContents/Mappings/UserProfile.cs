using AutoMapper;
using ViralRadar.Application.Users.Commands.CreateUser;
using ViralRadar.Domain.Entities;

namespace ViralRadar.Application.TrendContents.Mappings;

public class UserProfile:Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserCommand, User>().ReverseMap();
        CreateMap<CreatedUserResponse, User>().ReverseMap();

    }

}
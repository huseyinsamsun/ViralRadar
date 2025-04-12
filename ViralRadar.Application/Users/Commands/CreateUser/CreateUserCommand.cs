using MediatR;
using ViralRadar.Core.Common.Responses;

namespace ViralRadar.Application.Users.Commands.CreateUser;

public class CreateUserCommand:IRequest<BaseResponse<CreatedUserResponse> >
{
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
}
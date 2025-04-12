using Microsoft.AspNetCore.Mvc;
using ViralRadar.Application.Users.Commands.CreateUser;
using ViralRadar.Core.Common.Responses;

namespace ViralRadar.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController:BaseController
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserCommand createUserCommand)
    {
        BaseResponse<CreatedUserResponse> response = await Mediator.Send(createUserCommand);
        return Created("", response);
    }
}
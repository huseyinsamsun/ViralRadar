using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using ViralRadar.Application.Common;
using ViralRadar.Application.Interfaces;
using ViralRadar.Application.Rules;
using ViralRadar.Application.TrendContents.Commands;
using ViralRadar.Core.Common.Responses;
using ViralRadar.Core.Security;
using ViralRadar.Domain.Entities;

namespace ViralRadar.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler:IRequestHandler<CreateUserCommand, BaseResponse<CreatedUserResponse>>
{
    
    private readonly IUserRepository _userRepository;
    private readonly UserBusinessRules _userBusinessRules;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IMapper _mapper;
    private readonly ILogger<CreateUserCommand> _logger;  

    public CreateUserCommandHandler(IUserRepository userRepository, UserBusinessRules userBusinessRules,IPasswordHasher passwordHasher, IMapper mapper, ILogger<CreateUserCommand> logger)
    {
            _userRepository = userRepository;
            _userBusinessRules = userBusinessRules;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _logger = logger;
    }

    public async Task<BaseResponse<CreatedUserResponse>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Yeni user oluşturma başladı.{@Request}", request);
        try
        {
            BaseResponse<CreatedUserResponse> response = new BaseResponse<CreatedUserResponse>();
            
            var user = _mapper.Map<User>(request);
            await _userBusinessRules.UserEmailShouldNotExist(user.Email);
            await _userBusinessRules.UserUsernameShouldNotExist(user.Username);
            var hashedPassword = _passwordHasher.HashPassword(request.Password);
            user.PasswordHash = hashedPassword;
            _logger.LogInformation("Yeni user oluşturma tamamlandı.{@Request}", request);
            await _userRepository.AddAsync(user);
            CreatedUserResponse responseMessage = _mapper.Map<CreatedUserResponse>(user);   

            return BaseResponse<CreatedUserResponse>.SuccessResponse(responseMessage, CommonMessage.KayitEklemeBasarili);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        
    
    }
}
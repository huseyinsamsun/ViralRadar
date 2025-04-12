using ViralRadar.Application.Interfaces;

namespace ViralRadar.Application.Rules;

public class UserBusinessRules
{
    private readonly IUserRepository _userRepository;

    public UserBusinessRules(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    

    public async Task UserEmailShouldNotExist(string email)
    {
        var user = await _userRepository.FindAsync(u => u.Email == email);
        if (user != null&&user.Count()!=0) throw new Exception(Common.CommonMessage.KullaniciMevcut);
    }
    
    public async Task UserUsernameShouldNotExist(string userName)
    {
        var user = await _userRepository.FindAsync(u => u.Username == userName);
        if (user != null&&user.Count()!=0) throw new Exception(Common.CommonMessage.KullaniciMevcut);
    }
}
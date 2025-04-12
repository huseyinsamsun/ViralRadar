using ViralRadar.Core.Security.Models;

namespace ViralRadar.Core.Security;

public interface IJwtHelper
{
    TokenDto CreateToken(Guid userId,string userName, string email);
    string CreateRefreshToken();
}
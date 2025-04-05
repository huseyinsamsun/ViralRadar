using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class User:Entity<long>
    {
        public string Username { get;  set; }
        public string Email { get;  set; }
        public string PasswordHash { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public bool IsActive { get;  set; }
        public bool IsBanned { get;  set; }
        public DateTime? BannedUntil { get;  set; }
        public string? BanReason { get;  set; }
        public DateTime? LastLoginDate { get;  set; }
        public string? RefreshToken { get;  set; }
        public DateTime? RefreshTokenExpiry { get;  set; }

        public ICollection<UserInterest> UserInterests { get; set; }

        public ICollection<UserSavedContent> UserSavedContents { get; set; }


    }
}


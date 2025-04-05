using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class UserInterest:Entity<long>
	{
        public long UserId { get; set; }
        public long InterestId { get; set; }

        public User User { get; set; }
        public Interest Interest { get; set; }
    }
}


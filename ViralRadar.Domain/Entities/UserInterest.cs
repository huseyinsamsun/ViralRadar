using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class UserInterest:Entity<Guid>
	{
        public Guid UserId { get; set; }
        public Guid InterestId { get; set; }

        public User User { get; set; }
        public Interest Interest { get; set; }
    }
}


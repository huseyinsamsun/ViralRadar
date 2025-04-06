using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class UserSavedContent:Entity<Guid>
	{
       
        public Guid UserId { get; set; }
        public Guid TrendContentId { get; set; }

        public User User { get; set; }
        public TrendContent TrendContent { get; set; }
    }
}


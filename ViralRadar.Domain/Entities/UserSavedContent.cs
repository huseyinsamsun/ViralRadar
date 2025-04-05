using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class UserSavedContent:Entity<long>
	{
       
        public long UserId { get; set; }
        public long TrendContentId { get; set; }

        public User User { get; set; }
        public TrendContent TrendContent { get; set; }
    }
}


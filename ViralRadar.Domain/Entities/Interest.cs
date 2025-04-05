using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class Interest:Entity<long>
	{
        public string Name { get; set; }               // makeup, storytime, vs.
        public ICollection<TrendContentInterest> TrendContentInterests { get; set; }
        public ICollection<UserInterest> UserInterests { get; set; }
    }
}


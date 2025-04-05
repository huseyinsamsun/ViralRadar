using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class TrendContentInterest:Entity<long>
	{
        public long TrendContentId { get; set; }
        public long InterestId { get; set; }

        public TrendContent TrendContent { get; set; }
        public Interest Interest { get; set; }
    }
}


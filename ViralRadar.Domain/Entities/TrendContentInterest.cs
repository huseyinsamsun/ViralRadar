using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class TrendContentInterest:Entity<Guid>
	{
        public Guid TrendContentId { get; set; }
        public Guid InterestId { get; set; }

        public TrendContent TrendContent { get; set; }
        public Interest Interest { get; set; }
    }
}


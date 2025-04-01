using System;
namespace ViralRadar.Models
{
	public class TrendContentInterest
	{
        public int TrendContentId { get; set; }
        public int InterestId { get; set; }

        public TrendContent TrendContent { get; set; }
        public Interest Interest { get; set; }
    }
}


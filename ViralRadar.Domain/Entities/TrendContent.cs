using System;
using ViralRadar.Domain.Common;

namespace ViralRadar.Domain.Entities
{
	public class TrendContent:Entity<long>
	{
        
        public string Platform { get; set; }           // TikTok, Instagram
        public string Hashtag { get; set; }
        public string Sound { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string HookText { get; set; }           // AI önerisi vs.
        public int ViralScore { get; set; }

        public ICollection<TrendContentInterest> TrendContentInterests { get; set; }
    }
}


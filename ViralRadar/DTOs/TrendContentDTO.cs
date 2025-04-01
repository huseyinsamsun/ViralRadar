using System;
namespace ViralRadar.DTOs
{
	public class TrendContentDTO
	{
        public int Id { get; set; }
        public string Platform { get; set; }
        public string Hashtag { get; set; }
        public string Sound { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string HookText { get; set; }
        public int ViralScore { get; set; }
    }
}


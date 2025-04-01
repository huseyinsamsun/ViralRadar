using System;
namespace ViralRadar.Models
{
	public class TrendContent
	{
		public Guid Id { get; set; }
		public string Platform { get; set; }
		public string Hashtag { get; set; }
		public string Sound { get; set; }
		public int ViewCount { get; set; }
		public DateTime CreatedAt { get; set; }

	}
}


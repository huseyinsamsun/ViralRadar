namespace ViralRadar.Application.TrendContents.Queries.GetTrendContentById;

public class TrendContentByIdDto
{
 public Guid Id { get; set; }
 public string Platform { get; set; }           // TikTok, Instagram
 public string Hashtag { get; set; }
 public string Sound { get; set; }
 public int ViewCount { get; set; }
 public DateTime CreatedAt { get; set; }
 public string HookText { get; set; }           // AI önerisi vs.
 public int ViralScore { get; set; }
}
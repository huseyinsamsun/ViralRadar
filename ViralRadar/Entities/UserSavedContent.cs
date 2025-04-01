using System;
using ViralRadar.Models;

namespace ViralRadar.Entities
{
	public class UserSavedContent
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrendContentId { get; set; }
        public DateTime SavedAt { get; set; }

        public User User { get; set; }
        public TrendContent TrendContent { get; set; }
    }
}


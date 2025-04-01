using System;
using ViralRadar.Models;

namespace ViralRadar.Entities
{
	public class UserInterest
	{
        public int UserId { get; set; }
        public int InterestId { get; set; }

        public User User { get; set; }
        public Interest Interest { get; set; }
    }
}


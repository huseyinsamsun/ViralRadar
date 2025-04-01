using System;
namespace ViralRadar.Models
{
	public class Interest
	{
        public int Id { get; set; }
        public string Name { get; set; }               // makeup, storytime, vs.
        public ICollection<TrendContentInterest> TrendContentInterests { get; set; }
    }
}


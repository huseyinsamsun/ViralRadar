﻿using System;
namespace ViralRadar.Application.TrendContents.Dtos
{
	public class TrendContentDto
	{

        public string Platform { get; set; }
        public string Hashtag { get; set; }
        public string Sound { get; set; }
        public int ViewCount { get; set; }
        public string HookText { get; set; }
        public int ViralScore { get; set; }
    }
}


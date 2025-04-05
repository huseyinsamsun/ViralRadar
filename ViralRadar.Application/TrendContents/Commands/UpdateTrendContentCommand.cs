﻿using System;
namespace ViralRadar.Application.TrendContents.Commands
{
	public class UpdateTrendContentCommand
	{
        public long Id { get; set; }
        public string Platform { get; set; }
        public string Hashtag { get; set; }
        public string Sound { get; set; }
        public int ViewCount { get; set; }
        public string HookText { get; set; }
        public int ViralScore { get; set; }
    }
}


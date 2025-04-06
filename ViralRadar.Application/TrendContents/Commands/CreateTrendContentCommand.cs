using System;
using MediatR;
using ViralRadar.Core.Common.Responses;

namespace ViralRadar.Application.TrendContents.Commands
{
	public class CreateTrendContentCommand:IRequest<BaseResponse<CreateTrendContentResponse>>
	{
        public string Platform { get; set; }
        public string Hashtag { get; set; }
        public string Sound { get; set; }
        public int ViewCount { get; set; }
        public string HookText { get; set; }
        public int ViralScore { get; set; }
    }
}


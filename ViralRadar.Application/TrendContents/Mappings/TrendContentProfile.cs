using System;
using AutoMapper;
using ViralRadar.Application.TrendContents.Commands;
using ViralRadar.Application.TrendContents.Dtos;
using ViralRadar.Domain.Entities;

namespace ViralRadar.Application.TrendContents.Mappings
{
	public class TrendContentProfile:Profile
	{
		public TrendContentProfile()
		{
			CreateMap<CreateTrendContentCommand, TrendContent>().ReverseMap();
			CreateMap<TrendContent, TrendContentDto>().ReverseMap();
			CreateMap<CreateTrendContentResponse, TrendContent>().ReverseMap();


		}
	}
}


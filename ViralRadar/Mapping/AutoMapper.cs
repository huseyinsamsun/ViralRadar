using System;
using AutoMapper;
using ViralRadar.DTOs;
using ViralRadar.Models;

namespace ViralRadar.Mapping
{
	public class AutoMapper:Profile
	{
		public AutoMapper()
		{
			CreateMap<TrendContent, CreateTrendContentDTO>();
			CreateMap<TrendContent, TrendContentDTO>();
			CreateMap<User, UserDTO>();
			CreateMap<User, UserLoginDTO>();
			CreateMap<User, UserRegisterDTO>();
		}
		
	}
}


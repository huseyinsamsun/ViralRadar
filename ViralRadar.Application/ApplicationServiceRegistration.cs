using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ViralRadar.Application.Interfaces;

namespace ViralRadar.Application
{
	public static class ApplicationServiceRegistration
	{
		public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		
			
			return services;
		}
	
	}
}


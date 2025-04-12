using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ViralRadar.Application.Interfaces;
using ViralRadar.Application.Rules;
using ViralRadar.Core.Security;

namespace ViralRadar.Application
{
	public static class ApplicationServiceRegistration
	{
		public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			services.AddScoped<UserBusinessRules>();
			services.AddScoped<IPasswordHasher, PasswordHasher>();
			return services;
		}
	
	}
}


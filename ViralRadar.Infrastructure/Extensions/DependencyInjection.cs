using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ViralRadar.Application.Interfaces;
using ViralRadar.Infrastructure.Persistence.AppDbContext;
using ViralRadar.Infrastructure.Repositories;

namespace ViralRadar.Infrastructure.Extensions
{
	public static  class DependencyInjection
	{
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    sql => sql.MigrationsAssembly("ViralRadar.Infrastructure")));

            services.AddScoped<ITrendContentRepository, TrendContentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

    }
}


using System;
using Microsoft.EntityFrameworkCore;
using ViralRadar.Domain.Entities;
using ViralRadar.Application.Interfaces;
using ViralRadar.Infrastructure.Persistence.AppDbContext;

namespace ViralRadar.Infrastructure.Repositories
{
	public class TrendContentRepository:GenericRepository<TrendContent>,ITrendContentRepository
	{
        private readonly ApplicationDbContext _context;

        public TrendContentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}


using Microsoft.EntityFrameworkCore;
using ViralRadar.Application.Interfaces;
using ViralRadar.Domain.Entities;
using ViralRadar.Infrastructure.Persistence.AppDbContext;

namespace ViralRadar.Infrastructure.Repositories;

public class UserRepository:GenericRepository<User>,IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
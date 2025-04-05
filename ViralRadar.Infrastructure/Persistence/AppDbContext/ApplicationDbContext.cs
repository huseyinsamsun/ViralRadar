using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ViralRadar.Domain.Entities;

namespace ViralRadar.Infrastructure.Persistence.AppDbContext
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserInterest> UserInterests { get; set; }

        public DbSet<Interest> Interests { get; set; }

        public DbSet<TrendContent> TrendContents { get; set; }

        public DbSet<TrendContentInterest> TrendContentInterests { get; set; }

        public DbSet<UserSavedContent> UserSavedContents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            // UserInterest M:N
            modelBuilder.Entity<UserInterest>()
                .HasKey(ui => new { ui.UserId, ui.InterestId });

            modelBuilder.Entity<UserInterest>()
                .HasOne(ui => ui.User)
                .WithMany(u => u.UserInterests)
                .HasForeignKey(ui => ui.UserId);

            modelBuilder.Entity<UserInterest>()
                .HasOne(ui => ui.Interest)
                .WithMany(i => i.UserInterests)
                .HasForeignKey(ui => ui.InterestId);

            // TrendContentInterest M:N
            modelBuilder.Entity<TrendContentInterest>()
                .HasKey(tci => new { tci.TrendContentId, tci.InterestId });

            modelBuilder.Entity<TrendContentInterest>()
                .HasOne(tci => tci.TrendContent)
                .WithMany(tc => tc.TrendContentInterests)
                .HasForeignKey(tci => tci.TrendContentId);

            modelBuilder.Entity<TrendContentInterest>()
                .HasOne(tci => tci.Interest)
                .WithMany(i => i.TrendContentInterests)
                .HasForeignKey(tci => tci.InterestId);

            // UserSavedContent 1:N
            modelBuilder.Entity<UserSavedContent>()
                .HasOne(usc => usc.User)
                .WithMany(u => u.UserSavedContents)
                .HasForeignKey(usc => usc.UserId);

            modelBuilder.Entity<UserSavedContent>()
                .HasOne(usc => usc.TrendContent)
                .WithMany()
                .HasForeignKey(usc => usc.TrendContentId);
        }

    }
}


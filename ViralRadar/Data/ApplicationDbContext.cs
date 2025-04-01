using System;
using Microsoft.EntityFrameworkCore;
using ViralRadar.Entities;
using ViralRadar.Models;

namespace ViralRadar.Data
{
	public class ApplicationDbContext:DbContext
	{

        private readonly IConfiguration _config;
        public ApplicationDbContext(IConfiguration config)
        {
            _config = config;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,IConfiguration config):base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserInterest> UserInterests{ get; set; }

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
                .WithMany(u => u.SavedContents)
                .HasForeignKey(usc => usc.UserId);

            modelBuilder.Entity<UserSavedContent>()
                .HasOne(usc => usc.TrendContent)
                .WithMany()
                .HasForeignKey(usc => usc.TrendContentId);
        }


    }
}


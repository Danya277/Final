using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Model.Entities;
using Microsoft.Extensions.Configuration;

namespace Model.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ctx) : base(ctx)
        {

        }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAds> AdUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("ConnectionString");

            optionsBuilder
                .UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAds>()
                .HasKey(x => new { x.UserId, x.AdId });

            modelBuilder.Entity<UserAds>()
                .HasOne(x => x.User)
                .WithMany(x => x.UserAds)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserAds>()
                .HasOne(x => x.Ad)
                .WithMany(x => x.UserAds)
                .HasForeignKey(x => x.AdId);

            base.OnModelCreating(modelBuilder);

        }
    }
}

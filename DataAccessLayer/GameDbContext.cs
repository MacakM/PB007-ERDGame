using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class GameDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<DragonBoss> DragonBosses { get; set; }
        public DbSet<WyvernBoss> WyvernBosses { get; set; }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PB007";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Guild>()
                .HasOne(g => g.Leader)
                .WithOne(p => p.GuildLeader)
                .HasForeignKey<Guild>(g => g.LeaderId);
            base.OnModelCreating(modelBuilder);
        }
    }
}

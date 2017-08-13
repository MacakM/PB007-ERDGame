using System.Data.Entity;
using DAL.Entities;

namespace DAL
{
    public class GameDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Boss> Bosses { get; set; }
    }
}

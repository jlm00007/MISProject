using BaseballAPI.Entities;
using BaseballSiteAPI.Entities;
using Microsoft.EntityFrameworkCore;
namespace BaseballAPI.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DbContext> options): base(options) 
        { }
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Stat> Stat { get; set; }

    }
}

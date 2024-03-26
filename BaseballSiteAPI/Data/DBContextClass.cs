using BaseballSiteAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseballSiteAPI.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options) { }
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}

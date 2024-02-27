using BaseballAPI.Entities;
using Microsoft.EntityFrameworkCore;
namespace BaseballAPI.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DbContext> options): base(options) 
        { }
        public DbSet<Team> Team { get; set; }
    }
}

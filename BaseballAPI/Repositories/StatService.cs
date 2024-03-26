using BaseballAPI.Data;
using BaseballAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BaseballAPI.Repositories
{
    public class StatService: IStatService
    {
        private readonly DBContextClass _dbContextClass;
        public StatService(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Stat>> PlayerStat(string Name)
        {
            var param = new SqlParameter("@Name", Name);
            var PlayerStat = await Task.Run(() => _dbContextClass.Stat.FromSqlRaw("Exec spPlayerStat @Name", param).ToListAsync());
            return PlayerStat;
        }
    }
}

using BaseballSiteAPI.Data;
using BaseballSiteAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BaseballSiteAPI.Repositories
{

    public class StatService : IStatService
    {
        private readonly DBContextClass _dBContextClass;
        public StatService(DBContextClass dBContextClass)
        {
            _dBContextClass = dBContextClass;
        }
        public async Task<List<Stat>> PlayerStat(string Name)
        {
            var param = new SqlParameter("@Name", Name);
            var PlayerStat = await Task.Run(() => _dBContextClass.Stat.FromSqlRaw("Exec spPlayerStat @Name", param).ToListAsync());
            return PlayerStat;
        }
    }
}

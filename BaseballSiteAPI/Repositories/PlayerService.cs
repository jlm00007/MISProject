using BaseballSiteAPI.Data;
using BaseballSiteAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BaseballSiteAPI.Repositories
{
    public class PlayerService : IPlayerService
    {
        private readonly DBContextClass _dBContextClass;
        public PlayerService(DBContextClass dbContextClass)
        {
            _dBContextClass = dbContextClass;
        }
    public async Task<List<Player>> GetPlayersByTeam(int TeamID)
        {
            var param = new SqlParameter("@TeamID", TeamID);
            var PlayerDetails = await Task.Run(()=> _dBContextClass.Player.FromSqlRaw("exec spGetPlayersByTeam @TeamID", param).ToListAsync());
            return PlayerDetails;
        }
    }
}

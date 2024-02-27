using BaseballAPI.Data;
using BaseballAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace BaseballAPI.Repositories
{
    public class TeamInfo : ITeamInfo
    {
        private readonly DBContextClass _dbContextClass;
        public TeamInfo(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Team>> GetPlayersByTeam(int TID)
        {
            var param = new SqlParameter('@TeamID', TeamID);
            var teamDetails = await Task.Run(() => _dbContextClass.Team.FromSqlRaw("EXEC spGetPlayersByTeam @TeamID", param).ToListAsync());
                return teamDetails;
        }
    }
}

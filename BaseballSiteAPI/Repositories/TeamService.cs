using BaseballSiteAPI.Data;
using BaseballSiteAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BaseballSiteAPI.Repositories

{
    public class TeamService : ITeamService
    {
        private readonly DBContextClass _dbContextClass;

        public TeamService(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Team>> GetTeamsByDivision(string DivisionName)
        {
            var param = new SqlParameter("@DivisionName", DivisionName);
            var teamDetails = await Task.Run(() => _dbContextClass.Teams.FromSqlRaw("exec spGetTeamsByDivision @DivisionName", param).ToListAsync());
            return teamDetails;
        }
    }
}

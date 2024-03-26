using BaseballSiteAPI.Entities;

namespace BaseballSiteAPI.Repositories
{
    public interface ITeamService
    {
        public Task<List<Team>> GetTeamsByDivision(string DivisionName);
    }
}

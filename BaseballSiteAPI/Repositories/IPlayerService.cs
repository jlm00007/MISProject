using BaseballSiteAPI.Entities;

namespace BaseballSiteAPI.Repositories
{
    public interface IPlayerService
    {
        public Task<List<Player>> GetPlayersByTeam(int TeamID);
    }
}

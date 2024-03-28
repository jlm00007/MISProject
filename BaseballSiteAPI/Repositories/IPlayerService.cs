using BaseballSiteAPI.Entities;

namespace BaseballSiteAPI.Repositories
{
    public interface IPlayerService
    {
        public Task<List<Player>> GetPlayersByTeam(int TeamID);
        public Task<List<Player>> PlayerPos(string Position);
    }
}

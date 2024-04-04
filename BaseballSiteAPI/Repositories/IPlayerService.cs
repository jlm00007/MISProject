using BaseballSiteAPI.Entities;

namespace BaseballSiteAPI.Repositories
{
    public interface IPlayerService
    {
        public Task<List<Player>> GetPlayersByTeam(int TeamID);
        public Task<List<Player>> PlayerPos(string Position);

        public Task<List<Player>> PlayerGetDetails(int PID);
        public Task<int> AddPlayer(Player player);   
    }
}

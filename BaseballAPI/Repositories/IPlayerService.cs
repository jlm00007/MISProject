using System.Threading.Tasks;

using BaseballAPI.Entities;

namespace BaseballAPI.Repositories
{
    public interface IPlayerService
    {
        public Task<List<Player>> PlayerPos(string Position);
        public Task<List<Player>> PlayerStat(string Name);
    }
}

using System.Threading.Tasks;
using BaseballAPI.Entities;

namespace BaseballAPI.Repositories
{
    public interface IPlayerInfo
    {
        public Task<List<Player>> PlayerPos(string Position);
    }
}

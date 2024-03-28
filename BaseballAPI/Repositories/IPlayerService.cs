using System.Threading.Tasks;

using BaseballAPI.Entities;

namespace BaseballAPI.Repositories
{
    public interface IPlayerService
    {
        public Task<List<Player>> PlayerPos(string Position);

    }
}

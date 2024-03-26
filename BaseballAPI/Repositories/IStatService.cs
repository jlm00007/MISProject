using System.Threading.Tasks;
using BaseballAPI.Entities;

namespace BaseballAPI.Repositories
{
    public interface IStatService
    {
        public Task<List<Stat>> PlayerStat(string Name);
    }
}

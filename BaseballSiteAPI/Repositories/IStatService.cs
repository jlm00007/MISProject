using BaseballSiteAPI.Entities;

namespace BaseballSiteAPI.Repositories
{
    public interface IStatService
    {
        public Task<List<Stat>> PlayerStat(string Name);
    }
}

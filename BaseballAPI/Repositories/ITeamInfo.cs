namespace BaseballAPI.Repositories
{
    public interface ITeamInfo
    {
        public Task<List<TeamInfo> GetTeamInfoAsync()
    }
}

using BaseballAPI.Data;
using BaseballAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace BaseballAPI.Repositories
{
    public class PlayerService : IPlayerService
    {
        private readonly DBContextClass _dbContextClass;
        public PlayerService(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Player>> GetPlayerPos(string Position)
        {
            var param = new SqlParameter("Position", Position);
            var PlayerInfo = await Task.Run(() => _dbContextClass.Player.FromSqlRaw("EXEC spPlayerPos @Position", param).ToListAsync());
            return PlayerInfo;
        }
    }
}
using BaseballSiteAPI.Data;
using BaseballSiteAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BaseballSiteAPI.Repositories
{
    public class PlayerService : IPlayerService
    {
        private readonly DBContextClass _dBContextClass;
        public PlayerService(DBContextClass dbContextClass)
        {
            _dBContextClass = dbContextClass;
        }
        public async Task<List<Player>> GetPlayersByTeam(int TeamID)
        {
            var param = new SqlParameter("@TeamID", TeamID);
            var PlayerDetails = await Task.Run(() => _dBContextClass.Player.FromSqlRaw("exec spGetPlayersByTeam @TeamID", param).ToListAsync());
            return PlayerDetails;
        }
        public async Task<List<Player>> PlayerPos(string Position)
        {
            var param = new SqlParameter("@Position", Position);
            var PlayerPos = await Task.Run(() => _dBContextClass.Player.FromSqlRaw("EXEC spPlayerPos @Position", param).ToListAsync());
            return PlayerPos;
        }

        public async Task<List<Player>> PlayerGetDetails(int PID)
        {

            var param = new SqlParameter("@PID", PID);
            var playerDetails = await Task.Run(() => _dBContextClass.Player.FromSqlRaw("exec spGetPlayerDetails @PID", param).ToListAsync());
            return playerDetails;

        }
        public async Task<int> AddPlayer(Player player)
        {

            var PID = new SqlParameter("@PID", player.PID);
            var pName = new SqlParameter("Name", player.Name);
            var pNumber = new SqlParameter("Number", player.Number);
            var pPosition = new SqlParameter("Position", player.Position);
            var TID = new SqlParameter("TID", player.TID);
            var playerDetails = await Task.Run(() => _dBContextClass.Database.ExecuteSqlRaw("exec spAddPlayer @PID SMALLINT,\r\n    @Name NVARCHAR(max),\r\n    @Number NVARCHAR(max),\r\n    @Position NVARCHAR(max), \r\n    @TID SMALLINT"));
            return playerDetails;

        }

    }
}

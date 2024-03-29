﻿using BaseballAPI.Data;
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
        public async Task<List<Player>> PlayerPos(string Position)
        {
            var param = new SqlParameter("@Position", Position);
            var PlayerPos = await Task.Run(() => _dbContextClass.Player.FromSqlRaw("EXEC spPlayerPos @Position", param).ToListAsync());
            return PlayerPos;
        }

    }
}
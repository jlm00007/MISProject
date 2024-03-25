﻿using BaseballAPI.Entities;
using BaseballAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaseballAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly IPlayerService _PlayerService;
        public PlayerController(IPlayerService PlayerInfo)
        {

            _PlayerService = PlayerInfo;

        }
        [HttpGet("{getPlayerDetails}")]
        public async Task<List<Player>> PlayerPos(string Position)
        {
            var player = await _PlayerService.GetPlayerPos(Position);
            if (player == null)
            {
                //return NotFound();
            }
            return player;
        }

    }
}
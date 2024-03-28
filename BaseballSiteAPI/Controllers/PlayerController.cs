using BaseballSiteAPI.Entities;
using BaseballSiteAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaseballSiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }
        [HttpGet("getplayerdetails")]
        public async Task<List<Player>> GetPlayersByTeam(int TeamID)
        {
            var playerDetails = await playerService.GetPlayersByTeam(TeamID);
            if (playerDetails == null)
            {
                //return NotFound();
            }
            return playerDetails;
        }
        [HttpGet("{Position}")]
        public async Task<List<Player>> PlayerPos(string Position)
        {
            var player = await playerService.PlayerPos(Position);
            if (player == null)
            {
                //return NotFound();
            }
            return player;
        }

    }
}
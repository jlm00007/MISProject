using BaseballAPI.Entities;
using BaseballAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaseballAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly IPlayerInfo PlayerInfo;
        public PlayerController(IPlayerInfo PlayerInfo)
        {

            this.PlayerInfo = PlayerInfo;

        }
        [HttpGet("{getPlayerDetails}")]
        public async Task<List<Player>> PlayerPos(string Position)
        {
            var PlayerDetails = await PlayerInfo.PlayerPos(Position);
            if (PlayerDetails == null)
            {
                //return NotFound();
            }
            return PlayerDetails;
        }

    }
}
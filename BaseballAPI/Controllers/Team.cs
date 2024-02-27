using BaseballAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaseballAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : Controller
    {
        private readonly ITeamInfo teamInfo;
        public TeamController(ITeamInfo teamInfo) {
            
                this.teamInfo = teamInfo;
            
        }
        [HttpGet("{getTeamDetails}")]
        public async Task<List<Team>> teamGetDetails(int TID)
        {
            var teamDetails = await teamInfo.teamGetDetails(TID);
            if (teamDetails == null)
            {
                return NotFound()
            }
            return teamDetails
        }

    }
}

using BaseballSiteAPI.Entities;
using BaseballSiteAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BaseballSiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }
        [HttpGet("getteamsbydivision")]
        public async Task<List<Team>> GetTeamsByDivision(string DivisionName)
        {
            var teamDetails = await teamService.GetTeamsByDivision(DivisionName);
            if (teamDetails == null)
            {
                //return NotFound();
            }
            return teamDetails;
        }

    }
}
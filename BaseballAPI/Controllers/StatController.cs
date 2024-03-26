using BaseballAPI.Entities;
using BaseballAPI.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BaseballAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatController : Controller
    {
        private readonly IStatService _StatService;
        public StatController(IStatService StatService)
        {

            _StatService = StatService;

        }
        [HttpGet("{Name}")]
        public async Task<List<Stat>> PlayerStat(string Name)
        {
            var stat = await _StatService.PlayerStat(Name);
            if (stat == null)
            {
                //return NotFound();
            }
            return stat;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BaseballSiteAPI.Entities;
using MISProject.Data;

namespace MISProject.Pages.PlayerCRUD1
{
    public class IndexModel : PageModel
    {
        private readonly MISProject.Data.ApplicationDbContext _context;

        public IndexModel(MISProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}

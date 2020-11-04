using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskASP.Data;
using MegaDeskASP.Models;

namespace MegaDeskASP.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public IndexModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; }

        public async Task OnGetAsync()
        {
            Desk = await _context.Desk
                .Include(d => d.SurfaceMaterial).ToListAsync();
        }
    }
}

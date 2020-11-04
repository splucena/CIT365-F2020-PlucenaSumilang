using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskASP.Data;
using MegaDeskASP.Models;

namespace MegaDeskASP.Pages.SurfaceMaterials
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public IndexModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        public IList<SurfaceMaterial> SurfaceMaterial { get;set; }

        public async Task OnGetAsync()
        {
            SurfaceMaterial = await _context.SurfaceMaterial.ToListAsync();
        }
    }
}

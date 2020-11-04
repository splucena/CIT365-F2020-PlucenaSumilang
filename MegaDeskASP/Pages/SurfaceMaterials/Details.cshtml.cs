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
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public DetailsModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        public SurfaceMaterial SurfaceMaterial { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SurfaceMaterial = await _context.SurfaceMaterial.FirstOrDefaultAsync(m => m.SurfaceMaterialID == id);

            if (SurfaceMaterial == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

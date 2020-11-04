using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskASP.Data;
using MegaDeskASP.Models;

namespace MegaDeskASP.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public CreateModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //ViewData["SurfaceMaterialID"] = new SelectList(_context.SurfaceMaterial, "SurfaceMaterialID", "SurfaceMaterialID");
            ViewData["SurfaceMaterialID"] = new SelectList(_context.SurfaceMaterial, "SurfaceMaterialID", "Material");
            return Page();
        }

        [BindProperty]
        public Desk Desk { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

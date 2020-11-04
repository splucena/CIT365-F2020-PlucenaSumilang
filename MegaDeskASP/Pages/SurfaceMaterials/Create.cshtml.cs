using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskASP.Data;
using MegaDeskASP.Models;

namespace MegaDeskASP.Pages.SurfaceMaterials
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
            return Page();
        }

        [BindProperty]
        public SurfaceMaterial SurfaceMaterial { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SurfaceMaterial.Add(SurfaceMaterial);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

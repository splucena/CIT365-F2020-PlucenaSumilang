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
    public class DeleteModel : PageModel
    {
        private readonly MegaDeskASP.Data.MegaDeskASPContext _context;

        public DeleteModel(MegaDeskASP.Data.MegaDeskASPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Desk Desk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Desk = await _context.Desk
                .Include(d => d.SurfaceMaterial).FirstOrDefaultAsync(m => m.DeskID == id);

            if (Desk == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Desk = await _context.Desk.FindAsync(id);

            if (Desk != null)
            {
                _context.Desk.Remove(Desk);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

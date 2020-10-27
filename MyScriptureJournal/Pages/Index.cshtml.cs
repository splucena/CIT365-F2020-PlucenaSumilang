using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<ScriptureJournal> ScriptureJournal { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string BookSort { get; set; }
        public string DateAddedSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            //ScriptureJournal = await _context.ScriptureJournal.ToListAsync();
            // Search by book or keyword from note field
            var journals = from sj in _context.ScriptureJournal
                           select sj;

            if (!string.IsNullOrEmpty(SearchString))
            {
                journals = journals.Where(b => b.Book.Contains(SearchString) || b.Note.Contains(SearchString));

                ScriptureJournal = await journals.ToListAsync();
            }
            else
            {
                // Implement sorting
                BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
                DateAddedSort = sortOrder == "Date" ? "date_desc" : "Date";

                IQueryable<ScriptureJournal> journalsIQ = from sj in _context.ScriptureJournal
                                                          select sj;

                switch (sortOrder)
                {
                    case "book_desc":
                        journalsIQ = journalsIQ.OrderByDescending(sj => sj.Book);
                        break;
                    case "date_added_desc":
                        journalsIQ = journalsIQ.OrderBy(sj => sj.DateAdded);
                        break;
                    default:
                        journalsIQ = journalsIQ.OrderBy(sj => sj.ID);
                        break;
                }

                ScriptureJournal = await journalsIQ.AsNoTracking().ToListAsync();
            }
        }
    }
}

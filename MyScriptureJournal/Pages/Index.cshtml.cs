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

        public async Task OnGetAsync()
        {
            ScriptureJournal = await _context.ScriptureJournal.ToListAsync();

            var journals = from sj in _context.ScriptureJournal
                           select sj;

            if (!string.IsNullOrEmpty(SearchString))
            {
                journals = journals.Where(b => b.Book.Contains(SearchString) || b.Note.Contains(SearchString));
            }

            ScriptureJournal = await journals.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages.Entries
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get;set; } = default!;

        // search by book:
        [BindProperty(SupportsGet = true)]
        public string? SearchBookString { get; set; }

        //search by keywords in entries
        [BindProperty(SupportsGet = true)]
        public string? SearchEntryString { get; set; }


        public async Task OnGetAsync()
        {
            var entries = from e in _context.Entry
                          select e;
            if (!string.IsNullOrEmpty(SearchBookString))
            {
                entries = entries.Where(e => e.Reference.Contains(SearchBookString));
            }

            if (!string.IsNullOrEmpty(SearchEntryString))
            {
                entries = entries.Where(e => e.EntryText != null && e.EntryText.Contains(SearchEntryString));
            }

            Entry = await entries.ToListAsync();
        }
    }
}

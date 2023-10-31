using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskSite.Data;
using MegaDeskSite.Models;

namespace MegaDeskSite.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskSite.Data.MegaDeskSiteContext _context;

        public IndexModel(MegaDeskSite.Data.MegaDeskSiteContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; } = default!;

        
        [BindProperty(SupportsGet = true)]
        public string? SearchName { get; set; }



        public async Task OnGetAsync()
        {
            var quotes = from e in _context.DeskQuote
                          select e;
            if (_context.DeskQuote != null)
            {
                DeskQuote = await _context.DeskQuote.ToListAsync();
            }

            if (!string.IsNullOrEmpty(SearchName))
            {
                quotes = quotes.Where(e => e.CustomerName.ToLower() != null && e.CustomerName.Contains(SearchName.ToLower()));
    
            }
            DeskQuote = await quotes.ToListAsync();

        }
    }
}

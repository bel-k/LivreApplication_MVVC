using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using appPageRazor.Data;
using appPageRazor.Models;

namespace appPageRazor.Pages.Livres
{
    public class IndexModel : PageModel
    {
        private readonly appPageRazor.Data.LivreDbContext _context;

        public IndexModel(appPageRazor.Data.LivreDbContext context)
        {
            _context = context;
        }

        public IList<Livre> Livre { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Livres != null)
            {
                Livre = await _context.Livres.ToListAsync();
            }
        }
    }
}

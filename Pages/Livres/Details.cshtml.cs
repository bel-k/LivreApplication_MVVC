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
    public class DetailsModel : PageModel
    {
        private readonly appPageRazor.Data.LivreDbContext _context;

        public DetailsModel(appPageRazor.Data.LivreDbContext context)
        {
            _context = context;
        }

      public Livre Livre { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Livres == null)
            {
                return NotFound();
            }

            var livre = await _context.Livres.FirstOrDefaultAsync(m => m.ISBN == id);
            if (livre == null)
            {
                return NotFound();
            }
            else 
            {
                Livre = livre;
            }
            return Page();
        }
    }
}

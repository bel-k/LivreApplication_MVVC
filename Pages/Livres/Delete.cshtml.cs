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
    public class DeleteModel : PageModel
    {
        private readonly appPageRazor.Data.LivreDbContext _context;

        public DeleteModel(appPageRazor.Data.LivreDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Livres == null)
            {
                return NotFound();
            }
            var livre = await _context.Livres.FindAsync(id);

            if (livre != null)
            {
                Livre = livre;
                _context.Livres.Remove(Livre);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

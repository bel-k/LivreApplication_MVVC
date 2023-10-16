using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using appPageRazor.Data;
using appPageRazor.Models;

namespace appPageRazor.Pages.Livres
{
    public class EditModel : PageModel
    {
        private readonly appPageRazor.Data.LivreDbContext _context;

        public EditModel(appPageRazor.Data.LivreDbContext context)
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

            var livre =  await _context.Livres.FirstOrDefaultAsync(m => m.ISBN == id);
            if (livre == null)
            {
                return NotFound();
            }
            Livre = livre;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Livre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivreExists(Livre.ISBN))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LivreExists(string id)
        {
          return (_context.Livres?.Any(e => e.ISBN == id)).GetValueOrDefault();
        }
    }
}

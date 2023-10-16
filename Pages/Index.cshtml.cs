using appPageRazor.Data;
using appPageRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace appPageRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LivreDbContext _context;

        public IndexModel(LivreDbContext context)=> _context = context;
        public async void OnGet()
          {

              Livres =await _context.Livres.ToListAsync();
                  //.OrderByDescending(i=>i.createdAt)

          }
        public IEnumerable<Livre> Livres { get; set; }= Enumerable.Empty<Livre>();

    }
}
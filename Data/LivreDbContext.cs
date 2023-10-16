using appPageRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace appPageRazor.Data
{
    public class LivreDbContext : DbContext
    {
        public LivreDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Livre> Livres { get; set; }
       
    }
}

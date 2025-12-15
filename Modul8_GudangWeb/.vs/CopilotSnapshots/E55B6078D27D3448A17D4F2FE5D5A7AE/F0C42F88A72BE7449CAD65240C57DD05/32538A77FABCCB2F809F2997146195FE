using Microsoft.EntityFrameworkCore;

namespace Modul8_GudangWeb.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Barang> Barang { get; set; }
    }
}

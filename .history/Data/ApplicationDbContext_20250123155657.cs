using Microsoft.EntityFrameworkCore;
using ManipulationImage.Models;

namespace ManipulationImage.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using SuperMercadoLeo.Entities;

namespace SuperMercadoLeo.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Branch> Branches { get; set; }
    }
}
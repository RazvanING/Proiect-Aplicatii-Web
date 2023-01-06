//using CasaDiscuri.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDiscuri.Models
{
    public class StoreDbContext : DbContext
    {

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
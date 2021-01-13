using Microsoft.EntityFrameworkCore;
using RockyShop.Models;

namespace RockyShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}

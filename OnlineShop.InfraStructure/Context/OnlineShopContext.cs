using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Models;

namespace OnlineShop.InfraStructure.Context
{
    public class OnlineShopContext : DbContext
    {
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Email> Emails { get; set; }

    }
}

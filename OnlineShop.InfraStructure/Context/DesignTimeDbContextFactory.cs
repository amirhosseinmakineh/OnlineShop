using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OnlineShop.InfraStructure.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OnlineShopContext>
    {

        public OnlineShopContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OnlineShopContext>();
            builder.UseSqlServer("Data Source = .;Initial Catalog = OnlineShopDb;Integrated Security = true;TrustServerCertificate=True;");
            return new OnlineShopContext(builder.Options);

        }
    }
}
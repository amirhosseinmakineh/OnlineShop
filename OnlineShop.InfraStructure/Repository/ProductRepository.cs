using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;
using OnlineShop.InfraStructure.Context;

namespace OnlineShop.InfraStructure.Repository
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        public ProductRepository(OnlineShopContext context) : base(context)
        {
        }
    }
}

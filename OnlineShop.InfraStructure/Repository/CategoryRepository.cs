using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;
using OnlineShop.InfraStructure.Context;

namespace OnlineShop.InfraStructure.Repository
{
    public class CategoryRepository : BaseRepository<Category, int>,ICategoryRepository
    {
        public CategoryRepository(OnlineShopContext context) : base(context)
        {
        }
    }
}

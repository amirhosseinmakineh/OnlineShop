using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;
using OnlineShop.InfraStructure.Context;
namespace OnlineShop.InfraStructure.Repository
{
    public class SliderRepository : BaseRepository<Slider, int>, ISliderRepository
    {
        public SliderRepository(OnlineShopContext context) : base(context)
        {
        }
    }
}

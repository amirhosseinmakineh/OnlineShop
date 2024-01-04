using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;
using OnlineShop.InfraStructure.Context;

namespace OnlineShop.InfraStructure.Repository
{
    public class EmailRepository : BaseRepository<Email, int>, IEmailRepository
    {
        public EmailRepository(OnlineShopContext context) : base(context)
        {
        }
    }
}

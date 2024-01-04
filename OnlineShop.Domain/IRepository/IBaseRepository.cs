using OnlineShop.Domain.Models;

namespace OnlineShop.Domain.IRepository
{
    public interface IBaseRepository<Tentity, Tkey> where Tentity : BaseEntity<Tkey> where Tkey : struct
    {
        IQueryable<Tentity> GetAll();
        void Add(Tentity tentity);
        Tentity GetEntityById(Tkey id);
        void Delete(Tkey id);
        int SaveChange();
    }
}

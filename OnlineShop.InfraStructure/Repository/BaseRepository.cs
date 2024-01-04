using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;
using OnlineShop.InfraStructure.Context;

namespace OnlineShop.InfraStructure.Repository
{
    public class BaseRepository<Tentity, Tkey> : IBaseRepository<Tentity, Tkey> where Tentity : BaseEntity<Tkey> where Tkey : struct
    {
        private readonly OnlineShopContext context;

        public BaseRepository(OnlineShopContext context)
        {
            this.context = context;
        }

        public void Add(Tentity tentity)
        {
            context.Add(tentity);
        }

        public void Delete(Tkey id)
        {
            var entity = GetEntityById(id);
            entity.IsDelete = false;

        }

        public IQueryable<Tentity> GetAll()
        {
            return context.Set<Tentity>();
        }

        public Tentity GetEntityById(Tkey id)
        {
            var entity = context.Set<Tentity>().Find(id);
            return entity;
        }

        public int SaveChange()
        {
            return context.SaveChanges();
        }
    }
}

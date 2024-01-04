using Microsoft.EntityFrameworkCore.Storage;
using OnlineShop.Domain;
using OnlineShop.InfraStructure.Context;

namespace OnlineShop.InfraStructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContextTransaction transaction;
        private OnlineShopContext Context;

        public UnitOfWork(OnlineShopContext context)
        {
            Context = context;
        }

        public void Begin()
        {
            transaction = Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void RoleBck()
        {
            transaction.Rollback();
        }
    }
}

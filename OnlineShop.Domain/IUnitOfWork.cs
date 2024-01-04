namespace OnlineShop.Domain
{
    public interface IUnitOfWork
    {
        void Begin();
        void Commit();
        void RoleBck();
    }
}

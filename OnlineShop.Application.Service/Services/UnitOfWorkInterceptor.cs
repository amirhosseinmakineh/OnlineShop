using Castle.DynamicProxy;
using OnlineShop.Domain;

namespace OnlineShop.Application.Service.Services
{
    public class UnitOfWorkInterceptor : IInterceptor
    {
        private readonly IUnitOfWork unitOfWork;

        public UnitOfWorkInterceptor(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                unitOfWork.Begin();
                invocation.Proceed();
                unitOfWork.Commit();
            }catch (Exception ex)
            {
                unitOfWork.RoleBck();
            }
        }
    }
}

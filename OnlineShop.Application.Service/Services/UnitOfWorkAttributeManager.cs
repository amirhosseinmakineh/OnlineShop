using OnlineShop.ApplicationService.Contract.IServices;
using System.Reflection;

namespace OnlineShop.Application.Service.Services
{
    public class UnitOfWorkAttributeManager
    {
        private readonly HashSet<string> unitOfWorksMethods;

        public UnitOfWorkAttributeManager()
        {
            unitOfWorksMethods = new HashSet<string>();
        }
        public void SetValue()
        {
            var targets = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsAssignableTo(typeof(IService)) && !x.IsInterface);
        }
    }
}

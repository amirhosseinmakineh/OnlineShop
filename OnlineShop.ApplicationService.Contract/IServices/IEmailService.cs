using OnlineShop.ApplicationService.Contract.Dtos.Email;

namespace OnlineShop.ApplicationService.Contract.IServices
{
    public interface IEmailService
    {
        void SaveEmail(EmailAddDto dto);
    }
}

using OnlineShop.ApplicationService.Contract.Dtos.Email;
using OnlineShop.ApplicationService.Contract.IServices;
using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;

namespace OnlineShop.Application.Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository emailRepository;

        public EmailService(IEmailRepository emailRepository)
        {
            this.emailRepository = emailRepository;
        }

        public void SaveEmail(EmailAddDto dto)
        {
            var email = new Email()
            {
                EmailAddress = dto.Email
            };
            emailRepository.Add(email);
            emailRepository.SaveChange();
        }
    }
}

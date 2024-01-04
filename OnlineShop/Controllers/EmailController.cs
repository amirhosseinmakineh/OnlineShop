using Microsoft.AspNetCore.Mvc;
using OnlineShop.ApplicationService.Contract.Dtos.Email;
using OnlineShop.ApplicationService.Contract.IServices;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;

        public EmailController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpPost]
        public IActionResult PostEmail(EmailAddDto dto)
        {
            emailService.SaveEmail(dto);
            return Ok();
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ApplicationService.Contract.Dtos.Email
{
    public class EmailAddDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}

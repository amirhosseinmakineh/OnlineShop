using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Domain.Models
{
    public class Email : BaseEntity<int>
    {
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}

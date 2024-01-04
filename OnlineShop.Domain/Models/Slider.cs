using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Domain.Models
{
    public class Slider:BaseEntity<int>
    {
        [Required]
        public string ImageName { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Domain.Models
{
    public class BaseEntity<Tkey> where Tkey :struct
    {
        [Key]
        public Tkey Id { get; set; }
        public DateTime CreateEntityDate { get; set; }
        public bool IsDelete { get; set; }

    }
}

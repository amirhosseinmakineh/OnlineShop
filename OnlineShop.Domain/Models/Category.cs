using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Domain.Models
{
    public class Category:BaseEntity<int>
    {
        [Required]
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string? ImageName { get; set; }
        #region
        [ForeignKey("ParentId")]
        public Category Parent { get; set; }
        public ICollection<Category> SubCategory { get; set; }
        public ICollection<Product> Products { get; set; }
        #endregion
    }
}

using OnlineShop.Domain.Models;

namespace OnlineShop.ApplicationService.Contract.Dtos.ProductDto
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public float Price { get; set; }
        public Category Category { get; set; }
        public DateTime CreateDate { get; }
    }
}

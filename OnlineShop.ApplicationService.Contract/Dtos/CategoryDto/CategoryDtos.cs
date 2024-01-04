using OnlineShop.Domain.Models;

namespace OnlineShop.ApplicationService.Contract.Dtos.CategoryDto
{
    public class CategoryDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string ImageName { get; set; }
    }
}

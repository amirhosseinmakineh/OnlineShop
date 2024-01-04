using OnlineShop.Domain.Models;

namespace OnlineShop.ApplicationService.Contract.Dtos.CategoryDto
{
    public class SubCategoriesDto
    {
        public int Id { get; set; }
        public int? ParentId { get; set; } 
        public string Name { get; set; }
        public CategoryDtos Category { get; set; }
    }
}

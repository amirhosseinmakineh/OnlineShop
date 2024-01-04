using OnlineShop.ApplicationService.Contract.Dtos.CategoryDto;
using OnlineShop.ApplicationService.Contract.IServices;
using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;

namespace OnlineShop.Application.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public List<CategoryDtos> GetAllCategory()
        {
            var allCategory = new List<CategoryDtos>();
            allCategory = categoryRepository.GetAll().Select(x => new CategoryDtos()
            {
                Name = x.Name,
                Id = x.Id,
                ParentId = x.ParentId
            }).ToList();
            return allCategory;
        }

        public List<CategoryDtos> GetMainCategory()
        {
            var allCategory = new List<CategoryDtos>();
            allCategory = categoryRepository.GetAll().Where(x=> x.ParentId == null).Select(x => new CategoryDtos()
            {
                Name = x.Name,
                Id = x.Id,
                ImageName = x.ImageName
            }).Skip(0).Take(4).ToList();
            return allCategory;
        }

        public List<SubCategoriesDto> GetMainSubCategory()
        {
            List<CategoryDtos> categories = new List<CategoryDtos>();
            List<SubCategoriesDto> subCategory = new List<SubCategoriesDto>();
            var getParentCategory = categoryRepository.GetAll().Where(x => x.ParentId == null).ToList();
            foreach (var category in categories)
            {
                subCategory =  categoryRepository.GetAll().Where(x => x.ParentId == category.Id).Select(x=> new SubCategoriesDto()
               {
                    Id = x.Id,
                    ParentId = x.ParentId,
                    Category = getParentCategory.Select(x=> new CategoryDtos()
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).FirstOrDefault(),
                   Name = x.Name
               }).Skip(0).Take(4).ToList();
                if(subCategory.Count == 0)
                {
                    break;
                }
            }
            return subCategory;
        }

        public List<SubCategoriesDto> GetSubCategory(List<CategoryDtos> categories)
        {
            List<SubCategoriesDto> subCategory = new List<SubCategoriesDto>();
            var getParentCategory = categoryRepository.GetAll().Where(x => x.ParentId == null).ToList();
            foreach (var category in categories)
            {
                subCategory =  categoryRepository.GetAll().Where(x => x.ParentId == category.Id).Select(x=> new SubCategoriesDto()
               {
                    Id = x.Id,
                    ParentId = x.ParentId,
                    Category = getParentCategory.Select(x=> new CategoryDtos()
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).FirstOrDefault(),
                   Name = x.Name
               }).ToList();
                if(subCategory.Count == 0)
                {
                    break;
                }
            }
            return subCategory;
        }

    }
}

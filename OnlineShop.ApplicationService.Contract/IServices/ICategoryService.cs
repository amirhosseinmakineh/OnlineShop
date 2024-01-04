using OnlineShop.ApplicationService.Contract.Dtos.CategoryDto;

namespace OnlineShop.ApplicationService.Contract.IServices
{
    public interface ICategoryService
    {
        List<CategoryDtos> GetAllCategory();
        List<SubCategoriesDto> GetSubCategory(List<CategoryDtos> categories);
        #region MainPage
        List<CategoryDtos> GetMainCategory();
        List<SubCategoriesDto> GetMainSubCategory();

        #endregion
    }
}

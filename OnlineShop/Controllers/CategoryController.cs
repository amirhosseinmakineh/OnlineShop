using Microsoft.AspNetCore.Mvc;
using OnlineShop.ApplicationService.Contract.IServices;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
          var category =  categoryService.GetAllCategory();
            return Ok(category);
        }
        [HttpGet("MainCategory")]
        public IActionResult GetMainCategory()
        {
            var allMainCategory = categoryService.GetMainCategory();
            return Ok(allMainCategory);
        }
    }
}

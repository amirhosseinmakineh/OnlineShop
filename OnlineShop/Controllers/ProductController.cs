using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.ApplicationService.Contract.IServices;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
           var allProduct =  productService.GetAllProduct();
            return Ok(allProduct);
        }
        [HttpGet("GetLastProduct")]
        public IActionResult GetLastProduct()
        {
           var lastProduct =  productService.GetLastProduct();
            return Ok(lastProduct);
        }
        [HttpGet("GetNewProduct")]
        public IActionResult GetNewProduct()
        {
           var newroduct =  productService.GetNewProduct();
            return Ok(newroduct);
        }
    }
}

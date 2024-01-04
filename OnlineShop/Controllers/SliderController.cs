using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.ApplicationService.Contract.IServices;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService sliderService;

        public SliderController(ISliderService sliderService)
        {
            this.sliderService = sliderService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var sliders = sliderService.GetSliders();
            return Ok(sliders);
        }
    }
}

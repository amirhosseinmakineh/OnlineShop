using OnlineShop.ApplicationService.Contract.Dtos.SliderDto;
using OnlineShop.ApplicationService.Contract.IServices;
using OnlineShop.Domain.IRepository;

namespace OnlineShop.Application.Service.Services
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository sliderRepository;

        public SliderService(ISliderRepository sliderRepository)
        {
            this.sliderRepository = sliderRepository;
        }

        public List<SliderDto> GetSliders()
        {
            var slider = sliderRepository.GetAll().Select(x => new SliderDto()
            {
                ImageName = x.ImageName,
                ImagePath = "C://Users//asus//Downloads//"
            }).ToList();
            return slider;
        }
    }
}

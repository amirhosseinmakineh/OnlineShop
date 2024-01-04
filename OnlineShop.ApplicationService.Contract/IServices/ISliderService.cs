using OnlineShop.ApplicationService.Contract.Dtos.SliderDto;

namespace OnlineShop.ApplicationService.Contract.IServices
{
    public interface ISliderService
    {
        List<SliderDto> GetSliders();
    }
}

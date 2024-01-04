using OnlineShop.ApplicationService.Contract.Dtos.ProductDto;

namespace OnlineShop.ApplicationService.Contract.IServices
{
    public interface IProductService
    {
        List<ProductDto> GetAllProduct();
        List<ProductDto> GetLastProduct();
        List<ProductDto> GetNewProduct();
    }
}

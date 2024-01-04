using Microsoft.EntityFrameworkCore;
using OnlineShop.ApplicationService.Contract.Dtos.ProductDto;
using OnlineShop.ApplicationService.Contract.IServices;
using OnlineShop.Domain.IRepository;
using OnlineShop.Domain.Models;

namespace OnlineShop.Application.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public List<ProductDto> GetAllProduct()
        {
            var allProduct = productRepository.GetAll().Include(x => x.Category).Select(x => new ProductDto()
            {
                Name = x.Name,
                ImageName = x.ImageName,
                Price = x.Price,
                Category = new Category()
                {
                    Name = x.Category.Name,
                }
            }).ToList();
            return allProduct;
        }

        public List<ProductDto> GetLastProduct()
        {
            var lastProduct = productRepository.GetAll().Select(x => new ProductDto()
            {
                ImageName = x.ImageName,
                Name = x.Name,
                Price = x.Price
            }).OrderByDescending(x => x.CreateDate).ToList();
            return lastProduct;
        }

        public List<ProductDto> GetNewProduct()
        {
            var lastProduct = productRepository.GetAll().Select(x => new ProductDto()
            {
                ImageName = x.ImageName,
                Name = x.Name,
                Price = x.Price
            }).OrderBy(x => x.CreateDate).ToList();
            return lastProduct;
        }
    }
}

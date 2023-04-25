using PIM.Product.Domain.Dtos;
using PIM.Product.Domain.Repositories.Abstractions;
using PIM.Product.Domain.Requests;

namespace PIM.Product.Domain.Services.Abstractions
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<PagedResponse<Models.Product>> GetProductsAsync(
            GetProductsRequest getProductsRequest)
        {
            return await _productRepository.GetProductsAsync(getProductsRequest);
        }
    }
}

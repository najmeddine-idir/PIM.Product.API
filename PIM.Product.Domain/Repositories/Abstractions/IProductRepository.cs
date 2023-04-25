using PIM.Product.Domain.Dtos;
using PIM.Product.Domain.Requests;

namespace PIM.Product.Domain.Repositories.Abstractions
{
    public interface IProductRepository
    {
        Task<PagedResponse<Models.Product>> GetProductsAsync(
            GetProductsRequest getProductsRequest);
    }
}

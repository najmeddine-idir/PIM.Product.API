using PIM.Product.Domain.Dtos;
using PIM.Product.Domain.Requests;

namespace PIM.Product.Domain.Services.Abstractions
{
    public interface IProductService
    {
        Task<PagedResponse<Models.Product>> GetProductsAsync(
            GetProductsRequest getProductsRequest);
    }
}

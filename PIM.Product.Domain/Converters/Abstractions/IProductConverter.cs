using PIM.Product.Domain.Dtos;

namespace PIM.Product.Domain.Converters.Abstractions
{
    public interface IProductConverter
    {
        PagedResponse<ProductResponse> ToProductResponses(
            PagedResponse<Models.Product> productPagedResponse);
    }
}
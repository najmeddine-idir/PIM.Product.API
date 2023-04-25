using Microsoft.AspNetCore.Mvc;
using PIM.Product.Domain.Converters.Abstractions;
using PIM.Product.Domain.Dtos;
using PIM.Product.Domain.Requests;
using PIM.Product.Domain.Services.Abstractions;

namespace PIM.Product.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductConverter _productConverter;

        public ProductController(
            IProductService productService, 
            IProductConverter productConverter) 
        {
            _productService = productService;
            _productConverter = productConverter;
        }

        [HttpPost("search")]
        public async Task<ActionResult<PagedResponse<ProductResponse>>> GetProductsAsync(
            [FromBody] GetProductsRequest getProductsRequest)
        {
            var products = await _productService.GetProductsAsync(getProductsRequest);
            var productsResponse = _productConverter.ToProductResponses(products);

            return Ok(productsResponse);
        }
    }
}

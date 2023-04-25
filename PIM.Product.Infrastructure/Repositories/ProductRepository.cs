using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PIM.Product.Domain.Dtos;
using PIM.Product.Domain.Repositories.Abstractions;
using PIM.Product.Domain.Requests;
using PIM.Product.Infrastructure.Configurations;

namespace PIM.Product.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Domain.Models.Product> _productCollection;

        public ProductRepository(
            IOptions<ProductDatabaseConfiguration> productDatabaseConfiguration)
        {
            MongoDbInitializer.Initialize();

            var mongoClient = new MongoClient(
                productDatabaseConfiguration.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                productDatabaseConfiguration.Value.DatabaseName);

            _productCollection = mongoDatabase.GetCollection<Domain.Models.Product>(
                productDatabaseConfiguration.Value.CollectionName);
        }

        public async Task<PagedResponse<Domain.Models.Product>> GetProductsAsync(
            GetProductsRequest getProductsRequest)
        {
            var filterBuilder = Builders<Domain.Models.Product>.Filter;
            var filters = filterBuilder.Exists(x => x.Id, true);

            if (getProductsRequest.PimIds.Count > 0)
            {
                filters = filterBuilder.And(filters, filterBuilder.In(
                    x => x.PimId, getProductsRequest.PimIds));
            }

            var totalCount = await _productCollection.CountDocumentsAsync(filters);
            var skip = int.Parse(((getProductsRequest.PageIndex - 1) * getProductsRequest.PageSize).ToString());
            var take = (int)getProductsRequest.PageSize;
            var products = await _productCollection.Find(filters)
                .Skip(skip)
                .Limit(take)
                .ToListAsync();

            return new PagedResponse<Domain.Models.Product>
            {
                Data = products,
                Count = products.Count,
                PageIndex = (int)getProductsRequest.PageIndex,
                PageSize = (int)getProductsRequest.PageSize,
                TotalCount = totalCount,
            };
        }
    }
}

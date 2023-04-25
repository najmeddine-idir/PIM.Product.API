using PIM.Product.Domain.Converters.Abstractions;
using PIM.Product.Domain.Dtos;
using PIM.Product.Domain.Models;

namespace PIM.Product.Domain.Services.Abstractions
{
    public class ProductConverter : IProductConverter
    {
        public PagedResponse<ProductResponse> ToProductResponses(
            PagedResponse<Models.Product> products)
        {
            return new PagedResponse<ProductResponse>
            {
                Data = products.Data.Select(x => ToProductResponse(x)).ToList(),
                Count = products.Count,
                PageIndex = products.PageIndex,
                PageSize = products.PageSize,
                TotalCount = products.TotalCount
            };
        }

        private static ProductResponse ToProductResponse(
            Models.Product product)
        {
            return new ProductResponse
            {
                Id = product.Id,
                PimId = product.PimId,
                Nomenclature = ToNomenclatureResponse(product.Nomenclature),
            };
        }

        private static NomenclatureResponse? ToNomenclatureResponse(
            Nomenclature? nomenclature)
        {
            if (nomenclature is null) return null;

            return new NomenclatureResponse
            {
                Universe = ToReferentialResponse(nomenclature.Universe),
                Family = ToReferentialResponse(nomenclature.Family),
                SubFamily = ToReferentialResponse(nomenclature.SubFamily),
                ProductType = ToReferentialResponse(nomenclature.ProductType)
            };
        }

        private static ReferentialResponse<TId, TLabel>? ToReferentialResponse<TId, TLabel>(
            Referential<TId, TLabel>? referential)
        {
            if (referential is null) return null;

            return new ReferentialResponse<TId, TLabel>
            {
                Id = referential.Id,
                Label = ToTranslationResponse(referential.Label),
            };
        }

        private static TranslationResponse<T>? ToTranslationResponse<T>(
            Translation<T>? translation)
        {
            if (translation is null) return null;

            return new TranslationResponse<T>
            {
                Fr = translation.Fr,
            };
        }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace PIM.Product.Infrastructure.Configurations.ClassMaps
{
    /// <summary>
    /// 
    /// </summary>
    public static class ProductClassMap
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Initializer()
        {
            BsonClassMap.RegisterClassMap<Domain.Models.Product>(cm =>
            {
                cm.MapIdMember(c => c.Id)
                .SetElementName("_id")
                .SetIdGenerator(StringObjectIdGenerator.Instance)
                .SetSerializer(new StringSerializer(BsonType.ObjectId));
                cm.MapField(c => c.PimId).SetElementName("pimId").SetIgnoreIfNull(true);
                cm.MapField(c => c.Nomenclature).SetElementName("nomenclature").SetIgnoreIfNull(true);
            });

            BsonClassMap.RegisterClassMap<Domain.Models.Nomenclature>(cm =>
            {
                cm.MapField(c => c.Universe).SetElementName("universe").SetIgnoreIfNull(true);
                cm.MapField(c => c.Family).SetElementName("family").SetIgnoreIfNull(true);
                cm.MapField(c => c.SubFamily).SetElementName("subFamily").SetIgnoreIfNull(true);
                cm.MapField(c => c.ProductType).SetElementName("productType").SetIgnoreIfNull(true);
            });

            BsonClassMap.RegisterClassMap<Domain.Models.Referential<string, string>> (cm =>
            {
                cm.MapField(c => c.Id)
                .SetElementName("id")
                .SetSerializer(new StringSerializer(BsonType.ObjectId))
                .SetIgnoreIfNull(true);
                cm.MapField(c => c.Label).SetElementName("label").SetIgnoreIfNull(true);
            });

            BsonClassMap.RegisterClassMap<Domain.Models.Translation<string>> (cm =>
            {
                cm.MapField(c => c.Fr).SetElementName("fr").SetIgnoreIfNull(true);
                cm.MapField(c => c.Es).SetElementName("es").SetIgnoreIfNull(true);
                cm.MapField(c => c.It).SetElementName("it").SetIgnoreIfNull(true);
                cm.MapField(c => c.Nl).SetElementName("nl").SetIgnoreIfNull(true);
                cm.MapField(c => c.Pt).SetElementName("pt").SetIgnoreIfNull(true);
            });
        }
    }
}

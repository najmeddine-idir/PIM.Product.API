using PIM.Product.Infrastructure.Configurations.ClassMaps;

namespace PIM.Product.Infrastructure.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public static class MongoDbInitializer
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Initialize()
        {
            ProductClassMap.Initializer();
        }
    }
}

namespace PIM.Product.Domain.Models
{
    /// <summary>
    /// The product entity
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; init; } = string.Empty;

        /// <summary>
        /// PimId
        /// </summary>
        public string PimId { get; set; } = string.Empty;

        /// <summary>
        /// Nomenclature
        /// </summary>
        public Nomenclature? Nomenclature { get; set; }
    }
}

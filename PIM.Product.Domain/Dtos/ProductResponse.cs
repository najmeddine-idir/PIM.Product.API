namespace PIM.Product.Domain.Dtos
{
    /// <summary>
    /// The product entity
    /// </summary>
    public class ProductResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// PimId
        /// </summary>
        public string PimId { get; set; } = string.Empty;

        /// <summary>
        /// Nomenclature
        /// </summary>
        public NomenclatureResponse? Nomenclature { get; set; }
    }
}

namespace PIM.Product.Domain.Dtos
{
    /// <summary>
    /// Nomenclature
    /// </summary>
    public class NomenclatureResponse
    {
        /// <summary>
        /// Universe
        /// </summary>
        public ReferentialResponse<string, string>? Universe { get; set; }

        /// <summary>
        /// Family
        /// </summary>
        public ReferentialResponse<string, string>? Family { get; set; }

        /// <summary>
        /// SubFamily
        /// </summary>
        public ReferentialResponse<string, string>? SubFamily { get; set; }

        /// <summary>
        /// ProductType
        /// </summary>
        public ReferentialResponse<string, string>? ProductType { get; set; }
    }
}

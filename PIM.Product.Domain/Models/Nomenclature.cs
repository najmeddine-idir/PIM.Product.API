namespace PIM.Product.Domain.Models
{
    /// <summary>
    /// Nomenclature
    /// </summary>
    public class Nomenclature
    {
        /// <summary>
        /// Universe
        /// </summary>
        public Referential<string, string>? Universe { get; set; }

        /// <summary>
        /// Family
        /// </summary>
        public Referential<string, string>? Family { get; set; }

        /// <summary>
        /// SubFamily
        /// </summary>
        public Referential<string, string>? SubFamily { get; set; }

        /// <summary>
        /// ProductType
        /// </summary>
        public Referential<string, string>? ProductType { get; set; }
    }
}

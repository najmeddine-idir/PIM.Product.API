namespace PIM.Product.Domain.Models
{
    /// <summary>
    /// Referential
    /// </summary>
    public class Referential<TId, TLabel>
    {
        /// <summary>
        /// Id
        /// </summary>
        public TId? Id { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        public Translation<TLabel>? Label { get; set; }
    }
}

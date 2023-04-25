namespace PIM.Product.Domain.Dtos
{
    /// <summary>
    /// Referential
    /// </summary>
    public class ReferentialResponse<TId, TLabel>
    {
        /// <summary>
        /// Id
        /// </summary>
        public TId? Id { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        public TranslationResponse<TLabel>? Label { get; set; }
    }
}

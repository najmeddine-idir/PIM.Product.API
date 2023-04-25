namespace PIM.Product.Domain.Models
{
    /// <summary>
    /// Translation
    /// </summary>
    public class Translation<T>
    {
        /// <summary>
        /// Fr
        /// </summary>
        public T? Fr { get; set; }

        /// <summary>
        /// Es
        /// </summary>
        public T? Es { get; set; }

        /// <summary>
        /// It
        /// </summary>
        public T? It { get; set; }

        /// <summary>
        /// Nl
        /// </summary>
        public T? Nl { get; set; }

        /// <summary>
        /// Pt
        /// </summary>
        public T? Pt { get; set; }
    }
}

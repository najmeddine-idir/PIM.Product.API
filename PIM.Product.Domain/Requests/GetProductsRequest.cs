namespace PIM.Product.Domain.Requests
{
    public class GetProductsRequest
    {
        public IReadOnlyCollection<string> PimIds { get; set; } = new List<string>();

        public uint PageSize { get; set; } = 20;

        public uint PageIndex { get; set; } = 1;
    }
}

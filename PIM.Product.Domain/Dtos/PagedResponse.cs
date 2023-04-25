namespace PIM.Product.Domain.Dtos
{
    public class PagedResponse<T>
    {
        public IReadOnlyCollection<T> Data { get; set; } = new List<T>();

        public long Count { get; set; }

        public long TotalCount { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}

namespace DemoStoreEFCoreSidekick.WebApi
{
    public class PagedResult<TModel>
    {
        public int Total { get; set; }

        public IEnumerable<TModel> Data { get; set; } = Enumerable.Empty<TModel>();
    }
}

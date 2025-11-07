namespace Cu.ProductsApi.Blazor.Services.Models
{
    public class ResultModel<T> where T : class
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}

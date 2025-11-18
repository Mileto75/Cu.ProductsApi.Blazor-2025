using System.Text.Json.Serialization;

namespace Cu.ProductsApi.Blazor.Services.Models
{
    public class ProductFormModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }
    }
}

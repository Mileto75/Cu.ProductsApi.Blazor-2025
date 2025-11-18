using Cu.ProductsApi.Blazor.Components.UI.Models;
using System.Text.Json.Serialization;

namespace Cu.ProductsApi.Blazor.Services.Models
{
    public class ProductModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("category")]
        public CategoryModel Category { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }
    }
}


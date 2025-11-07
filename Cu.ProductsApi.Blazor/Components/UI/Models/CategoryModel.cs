using System.Text.Json.Serialization;

namespace Cu.ProductsApi.Blazor.Components.UI.Models
{
    public class CategoryModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}

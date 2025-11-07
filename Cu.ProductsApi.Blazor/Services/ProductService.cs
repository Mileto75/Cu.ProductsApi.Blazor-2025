using Cu.ProductsApi.Blazor.Components.UI.Models;
using Cu.ProductsApi.Blazor.Services.Models;
using System.ComponentModel;
using System.Text.Json;

namespace Cu.ProductsApi.Blazor.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.escuelajs.co/api/v1/");
        }

        public async Task<ResultModel<CategoryModel>> CreateCategoryAsync(CategoryModel categoryModel)
        {
            var resultModel = new ResultModel<CategoryModel>();
            var result = await _httpClient.PostAsJsonAsync("categories",categoryModel);
            if(result.IsSuccessStatusCode)
            {
                resultModel.IsSuccess = true;
                var content = await result.Content.ReadAsStringAsync();
                resultModel.Data = resultModel.Data = JsonSerializer.Deserialize<CategoryModel>(content);
                return resultModel;
            }
            resultModel.Errors = new List<string> { "Not created!" };
            return resultModel;
        }

        public async Task<ResultModel<CategoryModel>> DeleteCategoryAsync(int id)
        {
            var resultModel = new ResultModel<CategoryModel>();
            var result = await _httpClient.DeleteAsync($"categories/{id}");
            if (result.IsSuccessStatusCode)
            {
                resultModel.IsSuccess = true;
                return resultModel;
            }
            resultModel.Errors = new List<string> { "Not deleted!" };
            return resultModel;
        }

        public async Task<ResultModel<IEnumerable<CategoryModel>>> GetAllCategoriesAsync()
        {
            ResultModel<IEnumerable<CategoryModel>> resultModel = new();
            var result = await _httpClient.GetAsync("categories");
            if(result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                resultModel.Data = JsonSerializer.Deserialize<IEnumerable<CategoryModel>>(content);
                resultModel.IsSuccess = true;
                return resultModel;
            }
            resultModel.Errors = new List<string> { "Connection error!" };
            return resultModel;
        }

        public async Task<ResultModel<CategoryModel>> GetCategoryByIdAsync(int id)
        {
            ResultModel<CategoryModel> resultModel = new();
            var result = await _httpClient.GetAsync($"categories/{id}");
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                resultModel.Data = JsonSerializer.Deserialize<CategoryModel>(content);
                resultModel.IsSuccess = true;
                return resultModel;
            }
            resultModel.Errors = new List<string> { "Category not found!" };
            return resultModel;
        }

        public async Task<ResultModel<CategoryModel>> UpdateCategoryAsync(CategoryModel categoryModel)
        {
            var resultModel = new ResultModel<CategoryModel>();
            var result = await _httpClient.PutAsJsonAsync($"categories/{categoryModel.Id}", categoryModel);
            if (result.IsSuccessStatusCode)
            {
                resultModel.IsSuccess = true;
                var content = await result.Content.ReadAsStringAsync();
                resultModel.Data = resultModel.Data = JsonSerializer.Deserialize<CategoryModel>(content);
                return resultModel;
            }
            resultModel.Errors = new List<string> { "Not updated!" };
            return resultModel;
        }
    }
}

using Cu.ProductsApi.Blazor.Components.UI.Models;
using Cu.ProductsApi.Blazor.Services.Models;

namespace Cu.ProductsApi.Blazor.Services
{
    public interface IProductService
    {
        Task<ResultModel<IEnumerable<CategoryModel>>> GetAllCategoriesAsync();
        Task<ResultModel<CategoryModel>> GetCategoryByIdAsync(int id);
        Task<ResultModel<CategoryModel>> CreateCategoryAsync(CategoryModel categoryModel);
        Task<ResultModel<CategoryModel>> UpdateCategoryAsync(CategoryModel categoryModel);
        Task<ResultModel<CategoryModel>> DeleteCategoryAsync(int id);
        Task<ResultModel<IEnumerable<ProductModel>>> GetAllProductsAsync();
        Task<ResultModel<ProductModel>> GetProductByIdAsync(int id);
        Task<ResultModel<ProductModel>> CreateProductAsync(ProductModel productModel);
        Task<ResultModel<ProductModel>> UpdateProductAsync(ProductModel productModel);
        Task<ResultModel<ProductModel>> DeleteProductAsync(int id);
    }
}

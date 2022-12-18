using WebFlash.Service.API.ProductApi.Models.Dtos;
namespace WebFlash.Service.API.ProductApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int id);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}

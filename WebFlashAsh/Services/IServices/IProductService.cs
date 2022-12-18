using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlashAsh.Models;

namespace WebFlashAsh.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetAllProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}

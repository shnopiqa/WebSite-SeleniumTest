using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.Service.API.ProductApi.Models;
using WebFlash.Service.API.ProductApi.Models.Dtos;
using WebFlash.Service.API.ProductAPI.DbContexts;

namespace WebFlash.Service.API.ProductApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Products product = _mapper.Map<ProductDto, Products > (productDto);
            if (product.ProductId > 0)
            {
                _db.Products.Update(product);
            }
            else 
            {
                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Products, ProductDto>(product);
        }


        public async Task<bool> DeleteProduct(int productId)
        {
            try 
            {
                Products product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                if (product == null) 
                {
                    return false;
                }
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Products product = await _db.Products.Where(p => p.ProductId == productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Products> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}

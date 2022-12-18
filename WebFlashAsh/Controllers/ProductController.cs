using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebFlashAsh.Models;
using WebFlashAsh.Services.IServices;

namespace WebFlashAsh.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> listProducts = new List<ProductDto>();
            var response = await _productService.GetAllProductsAsync<ResponseDto>();
            if(response!=null && response.IsSuccess) 
            {
                listProducts = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(listProducts);
        }
        public async Task<IActionResult> ProductCreate()
        { 

            return View();
        }
    }
}

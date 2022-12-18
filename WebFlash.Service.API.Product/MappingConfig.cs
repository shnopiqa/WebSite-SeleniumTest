using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.Service.API.Product.Models.Dtos;
using WebFlash.Service.API.ProductApi.Models;
using WebFlash.Service.API.ProductApi.Models.Dtos;

namespace WebFlash.Service.API.ProductApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Products>();
                config.CreateMap<Products, ProductDto>();
            });
            return mappingConfig;
        }
    }
}

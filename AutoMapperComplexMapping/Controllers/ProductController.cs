using AutoMapper;
using AutoMapperComplexMapping.DTOs;
using AutoMapperComplexMapping.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperComplexMapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper)
        {
            _mapper = mapper;
        }
        List<Category> listCategories = new List<Category>()
        {
            new Category()
            {
                Id = 1,
                Name="Electronics",
                Products = new List<Product>()
                {
                   new Product(){ Id=101,Name="Laptop",Description="Laptop",Price=20000,CategoryId=1},
                   new Product(){ Id=102,Name="Desktop",Description="Desktop",Price=10000,CategoryId=1}
                 }
            },
            new Category()
            {
                Id =2,
                Name="Cloths",
                Products=new List<Product>()
                {
                     new Product(){ Id=103,Name="T-Shirt",Description="T-Shirt",Price=1000,CategoryId=2},
                     new Product(){ Id=104,Name="Jacket",Description="Jacket",Price=2000,CategoryId=2}
                }
            }
        };

        [HttpGet("Categories")]
        public ActionResult<List<CategoryDTO>> getAllCategory()
        {
            var categories = _mapper.Map<List<CategoryDTO>>(listCategories);
            return Ok(categories);
        }
    }
}

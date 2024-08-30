using AutoMapperComplexMapping.Models;

namespace AutoMapperComplexMapping.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductDTO> ProductsDTO { get; set; }
    }
}

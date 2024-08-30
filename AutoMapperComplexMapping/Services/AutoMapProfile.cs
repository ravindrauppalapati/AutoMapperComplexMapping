using AutoMapper;
using AutoMapperComplexMapping.DTOs;
using AutoMapperComplexMapping.Models;

namespace AutoMapperComplexMapping.Services
{
    public class AutoMapProfile : Profile
    {
        public AutoMapProfile() 
        {
            // CreateMap<Category,CategoryDTO>();
            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.ProductsDTO, act => act.MapFrom(src => src.Products));
            //CreateMap<Product,ProductDTO>();
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.ProductName,act => act.MapFrom(src => src.Name))
                 .ForMember(dest => dest.ProductPrice, act => act.MapFrom(src => src.Price));
        }
    }
}

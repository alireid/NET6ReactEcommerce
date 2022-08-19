using NET6ReactEcommerce.DTOs;
using NET6ReactEcommerce.Entities;
using AutoMapper;

namespace NET6ReactEcommerce.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
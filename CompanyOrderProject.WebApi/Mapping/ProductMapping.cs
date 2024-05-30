using AutoMapper;
using CompanyOrderProject.DtoLayer.ProductDto;
using CompanyOrderProject.EntityLayer.Concrete;

namespace CompanyOrderProject.WebApi.Mapping
{
    public class ProductMapping :Profile
    {
        public ProductMapping()
        {
            CreateMap< Product ,ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
        }
    }
}

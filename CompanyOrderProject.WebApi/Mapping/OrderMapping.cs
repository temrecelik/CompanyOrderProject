using AutoMapper;
using CompanyOrderProject.DtoLayer.OrderDto;
using CompanyOrderProject.DtoLayer.ProductDto;
using CompanyOrderProject.EntityLayer.Concrete;

namespace CompanyOrderProject.WebApi.Mapping
{
    public class OrderMapping :Profile
    {
        public OrderMapping()
        {
            CreateMap<Order , ResultOrderDto > ().ReverseMap();
            CreateMap<Order, CreateOrderDto>().ReverseMap();

        }
    }
}

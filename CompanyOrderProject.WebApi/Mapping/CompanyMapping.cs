using AutoMapper;
using CompanyOrderProject.DtoLayer.CompanyDto;
using CompanyOrderProject.EntityLayer.Concrete;
using System.Runtime;

namespace CompanyOrderProject.WebApi.Mapping
{
    public class CompanyMapping :Profile 
    {
        public CompanyMapping()
        {
                CreateMap<Company ,ResultCompanyDto>().ReverseMap();
                CreateMap<Company, GetCompanyDto>().ReverseMap();
                CreateMap<Company, CreateCompanyDto>().ReverseMap();
                CreateMap<Company, UpdateCompanyDto>().ReverseMap();
        }
    }
}

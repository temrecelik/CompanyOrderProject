using CompanyOrderProject.BusinessLayer.Abstract;
using CompanyOrderProject.DataAccessLayer.Concrete;
using CompanyOrderProject.DtoLayer.CompanyDto;
using CompanyOrderProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyOrderProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly Context _context;

        public CompanyController(ICompanyService companyService, Context context)
        {
            _companyService = companyService;
            _context = context;
        }

        [HttpGet]
        public IActionResult CompanyList() { 
            var values =  _companyService.TGetList();
            return Ok(values);
        }


        [HttpPost]
      
        public IActionResult AddCompany(CreateCompanyDto  createCompanyDto)
        {
            Company company = new Company()
            {
                CompanyName = createCompanyDto.CompanyName,
                ApprovalStatus = createCompanyDto.ApprovalStatus,
                OrderPermissionEnd = createCompanyDto.OrderPermissionEnd,
                OrderPermissionStart = createCompanyDto.OrderPermissionStart,
            };


            _companyService.TInsert(company);
            return Ok("Company added successfully");
        }

        [HttpPut]
        public IActionResult UpdateCompany(UpdateCompanyDto updateCompanyDto)
        {
        var company = _context.Companies.FirstOrDefault(c => c.CompanyId == updateCompanyDto.CompanyId);

        if (company == null)
            {
                return BadRequest("company not found");
            }

            company.ApprovalStatus = updateCompanyDto.ApprovalStatus;
            company.OrderPermissionStart = updateCompanyDto.OrderPermissionStart;
            company.OrderPermissionEnd = updateCompanyDto.OrderPermissionEnd;

            _companyService.TUpdate(company);
            return Ok("Company updated successfully");

            
            
        }
    }
}

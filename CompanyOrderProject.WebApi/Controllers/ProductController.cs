using CompanyOrderProject.BusinessLayer.Abstract;
using CompanyOrderProject.DataAccessLayer.Concrete;
using CompanyOrderProject.DtoLayer.ProductDto;
using CompanyOrderProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace CompanyOrderProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly Context _context;

        public ProductController(IProductService productService, Context context)
        {
            _productService = productService;
            _context = context;
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductDto createProductDto)
        {
            


            Product product = new Product()
            {
                ProductName = createProductDto.ProductName,
                ProductStock = createProductDto.ProductStock,
                ProductPrice = createProductDto.ProductPrice,
                CompanyId = createProductDto.CompanyId,
            };  
            
            var company = _context.Companies.FirstOrDefault(c => c.CompanyId == product.CompanyId);
            if (company == null)
            {
                return BadRequest("Please Enter Correct CompanyID");
            }

            else { 
            _productService.TInsert(product);
            return Ok("ProductAddedSuccessfully");
            
           }
            
        }
    }
}

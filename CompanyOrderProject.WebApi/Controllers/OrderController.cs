using AutoMapper.Configuration.Conventions;
using CompanyOrderProject.BusinessLayer.Abstract;
using CompanyOrderProject.DataAccessLayer.Concrete;
using CompanyOrderProject.DtoLayer.OrderDto;
using CompanyOrderProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace CompanyOrderProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly Context _context;

        public OrderController(IOrderService orderService, Context context)
        {
            _orderService = orderService;
            _context = context;
        }

        [HttpPost]
        public IActionResult AddOrder(CreateOrderDto orderDto)
        {
            int ProductId = orderDto.ProductId;

            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
                if (product == null)
                {
                    return BadRequest("Product not found");
                }

            int CamponyId = product.CompanyId;

            var company = _context.Companies.FirstOrDefault(c => c.CompanyId ==  CamponyId);
            if (company == null)
            {
                return BadRequest("Company not found");
            }

            if (!company.ApprovalStatus)
            {
                return BadRequest("The company is not approved");
            }

            if (!IsOrderTimeValid(orderDto.OrderDate.TimeOfDay, company.OrderPermissionStart.TimeOfDay, company.OrderPermissionEnd.TimeOfDay))
            {
                return BadRequest("Order time is not valid");
            }

            bool IsOrderTimeValid(TimeSpan orderTime, TimeSpan permissionStart, TimeSpan permissionEnd)
            {
                return orderTime >= permissionStart && orderTime <= permissionEnd;
            }

            Order order = new Order()
            {
                OrderDate = orderDto.OrderDate,
                OrderingPerson = orderDto.OrderingPerson,
                ProductId = orderDto.ProductId,
            };

            _orderService.TInsert(order);
            return Ok("Order added Successfully");

        }
    }
}

using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompanyOrderProject.EntityLayer.Concrete
{
    public class Product
    {
       
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }
        
        public int ProductStock {  get; set; }  
        
        public float ProductPrice { get; set; }
        
        public int CompanyId { get; set; }  
        public Company Company { get; set; }    

        public ICollection<Order> Order { get; set; } = new List<Order>();

    }
}

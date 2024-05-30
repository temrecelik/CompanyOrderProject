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
    public class Order
    {
       
        public int OrderId { get; set; }
        
        public string OrderingPerson { get; set; }
        
        public DateTime OrderDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }


      
    }
}

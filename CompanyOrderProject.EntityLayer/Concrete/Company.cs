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
    public class Company
    {
       
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public bool ApprovalStatus{ get; set; }

        public DateTime OrderPermissionStart { get; set; }  

        public DateTime OrderPermissionEnd { get; set;}


        public List<Product> Products { get; set; } 
     

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderProject.DtoLayer.ProductDto
{
    public class CreateProductDto
    {

        public string ProductName { get; set; }

        public int ProductStock { get; set; }

        public float ProductPrice { get; set; }

       public int CompanyId { get; set; }
    }
}

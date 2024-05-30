using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderProject.DtoLayer.OrderDto
{
    public class CreateOrderDto
    {
        public string OrderingPerson { get; set; }

        public DateTime OrderDate { get; set; }

        public int ProductId { get; set; }
    }
}

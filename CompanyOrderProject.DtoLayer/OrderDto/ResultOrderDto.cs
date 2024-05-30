using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderProject.DtoLayer.OrderDto
{
    public class ResultOrderDto
    {
        public int OrderId { get; set; }

        public string OrderingPerson { get; set; }

        public DateTime OrderDate { get; set; }
    }
}

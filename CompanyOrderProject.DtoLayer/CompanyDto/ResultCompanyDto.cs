using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderProject.DtoLayer.CompanyDto
{
    public class ResultCompanyDto
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public bool ApprovalStatus { get; set; }

        public DateTime OrderPermissionStart { get; set; }

        public DateTime OrderPermissionEnd { get; set; }
    }
}

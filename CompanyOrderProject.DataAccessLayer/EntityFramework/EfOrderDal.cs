using CompanyOrderProject.DataAccessLayer.Abstract;
using CompanyOrderProject.DataAccessLayer.Concrete;
using CompanyOrderProject.DataAccessLayer.Repositories;
using CompanyOrderProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderProject.DataAccessLayer.EntityFramework
{
   public class EfOrderDal :GenericRepository<Order> ,IOrderDal
    {
        public EfOrderDal(Context context) : base(context) { }

    }
}

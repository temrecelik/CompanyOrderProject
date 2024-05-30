using CompanyOrderProject.BusinessLayer.Abstract;
using CompanyOrderProject.DataAccessLayer.Abstract;
using CompanyOrderProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderProject.BusinessLayer.Concrete
{
    public class IOrderManager : IOrderService
    {

        private readonly IOrderDal _orderDal;

        public IOrderManager(IOrderDal orderDal)
        {
            this._orderDal = orderDal;
        }

        public void TDelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order TGetByID(int id)
        {
            return _orderDal.GetByID(id);
        }

        public List<Order> TGetList()
        {
            return _orderDal.GetList();
        }

        public void TInsert(Order t)
        {
           _orderDal.Insert(t);
        }

        public void TUpdate(Order t)
        {
           _orderDal.Update(t);
        }
    }
}

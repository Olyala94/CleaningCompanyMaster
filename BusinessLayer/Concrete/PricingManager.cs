using BusinessLayer.Aabstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PricingManager : IPricingService
    {
        IPricingDal _pricingDal;

        public PricingManager(IPricingDal pricingDal)
        {
            _pricingDal = pricingDal;
        }

        public List<Pricing> GetList()
        {
            return _pricingDal.GetList();
        }

        public void TAdd(Pricing t)
        {
           _pricingDal.Insert(t);
        }

        public Pricing TGetById(int id)
        {
           return _pricingDal.GetByID(id);  
        }

        public void TRemove(Pricing t)
        {
            _pricingDal.Delete(t);
        }

        public void TUpdate(Pricing t)
        {
          _pricingDal.Update(t);
        }
    }
}

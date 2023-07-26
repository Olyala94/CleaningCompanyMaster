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
    public class ClientTestimonialManager : IClientTestimonialService
    {
        IClientTestimonialDal _clientTestimonial;

        public ClientTestimonialManager(IClientTestimonialDal clientTestimonial)
        {
            _clientTestimonial = clientTestimonial;
        }

        public List<ClientTestimonial> GetList()
        {
          return  _clientTestimonial.GetList();   
        }

        public void TAdd(ClientTestimonial t)
        {
            _clientTestimonial.Insert(t);
        }

        public ClientTestimonial TGetById(int id)
        {
           return _clientTestimonial.GetByID(id);
        }

        public void TRemove(ClientTestimonial t)
        {
            _clientTestimonial.Delete(t);
        }

        public void TUpdate(ClientTestimonial t)
        {
            _clientTestimonial.Update(t);
        }
    }
}

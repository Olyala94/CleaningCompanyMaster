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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUs;

        public ContactUsManager(IContactUsDal contactUs)
        {
            _contactUs = contactUs;
        }

        public List<ContactUs> GetList()
        {
            return _contactUs.GetList();
        }

        public void TAdd(ContactUs t)
        {
            _contactUs.Insert(t);
        }

        public ContactUs TGetById(int id)
        {
            return _contactUs.GetByID(id);
        }

        public void TRemove(ContactUs t)
        {
            _contactUs.Delete(t);
        }

        public void TUpdate(ContactUs t)
        {
            _contactUs.Update(t);
        }
    }
}

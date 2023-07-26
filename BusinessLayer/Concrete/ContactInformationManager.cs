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
    public class ContactInformationManager : IContactInformationService
    {
        IContactInformationDal _contactInformationDal;

        public ContactInformationManager(IContactInformationDal contactInformationDal)
        {
            _contactInformationDal = contactInformationDal;
        }

        public List<ContactInformation> GetList()
        {
            return _contactInformationDal.GetList();   
        }

        public void TAdd(ContactInformation t)
        {
            _contactInformationDal.Insert(t);
        }

        public ContactInformation TGetById(int id)
        {
           return _contactInformationDal.GetByID(id);
        }

        public void TRemove(ContactInformation t)
        {
           _contactInformationDal.Delete(t);
        }

        public void TUpdate(ContactInformation t)
        {
            _contactInformationDal.Update(t);
        }
    }
}

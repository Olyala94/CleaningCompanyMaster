using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace CleaningCompanyMaster.ViewComponents.Service
{
    public class ServiceList: ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetList();
            return View(values);
        }
    }
}

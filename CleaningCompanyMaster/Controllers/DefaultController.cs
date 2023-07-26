using Microsoft.AspNetCore.Mvc;

namespace CleaningCompanyMaster.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

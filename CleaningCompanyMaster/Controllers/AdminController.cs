using Microsoft.AspNetCore.Mvc;

namespace CleaningCompanyMaster.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

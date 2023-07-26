using CleaningCompanyMaster.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleaningCompanyMaster.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterUserModel p)
        {

            ApplicationUser applicationUser = new ApplicationUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                UserName = p.UserName,
                Email = p.Email,
                Customer = p.Customer,
                Master = p.Master
                
            };

            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(applicationUser, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}

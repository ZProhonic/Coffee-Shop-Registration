using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome", user);
            }

            return View(user);
        }

        public IActionResult Welcome(User user)
        {
            return View(user);
        }

    }
}

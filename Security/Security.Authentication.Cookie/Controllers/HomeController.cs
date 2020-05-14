using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Security.Authentication.Cookie.Models;

namespace Security.Authentication.Cookie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Users()
        {
            return View(new User().GetUsers());
        }
    }
}

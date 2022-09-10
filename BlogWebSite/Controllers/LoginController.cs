using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorPage(int code)
        {
            return View();
        }
    }
}

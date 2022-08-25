using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = aboutManager.getList();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}

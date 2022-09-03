using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogmanager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogmanager.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            var values = blogmanager.GetBlogById(id);
            return View(values);
        }
    }
}

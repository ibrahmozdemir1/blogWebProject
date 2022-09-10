using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var value = manager.getList();
            return View(value);
        }
    }
}

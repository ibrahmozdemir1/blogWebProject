using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Blog
{
    public class BlogLastThreePost : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.getLastThreePost();
            return View(values);
        }
    }
}

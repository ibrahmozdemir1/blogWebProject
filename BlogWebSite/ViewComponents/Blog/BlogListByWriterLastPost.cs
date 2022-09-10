using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Blog
{
	public class BlogListByWriterLastPost : ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = blogManager.GetBlogListByWriter(4);
			return View(values);
		}

	}
}

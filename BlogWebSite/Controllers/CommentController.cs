using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
        [HttpPost]

        public PartialViewResult CommentListByBlog(int id)
		{
			var blogComment = commentManager.getList(id);
			return PartialView(blogComment);
		}

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 3;
            commentManager.CommentAdd(p);
            return PartialView();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            CommentManager commentManager = new CommentManager(new EfCommentRepository());
            var values = commentManager.getList(id);
            return View(values);
        }
    }
}

using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    [AllowAnonymous]
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
            ViewBag.i = id;
            var values = blogmanager.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var bloglistByWriter = blogmanager.GetBlogListByWriter(4);
            return View(bloglistByWriter);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {

            BlogValidator blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(p);
            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 4;
                blogmanager.Add(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


    }
}

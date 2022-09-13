using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class ContactController : Controller
    {
        ContactManager _contactManager = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact c)
        {
            c.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.ContactStatus = true;
            _contactManager.AddContact(c);
            return RedirectToAction("Index","Blog");
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BlogWebSite.Controllers
{
    public class RegisterController : Controller
	{
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [HttpGet]
            
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            p.WriterStatus = true;
            p.WriterAbout = "deneme";
            writerManager.WriterAdd(p);
            return RedirectToAction("Index","Blog");
        }


    }
}

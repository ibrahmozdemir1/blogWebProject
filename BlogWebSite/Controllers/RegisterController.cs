using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            WriterValidator validationRules = new WriterValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "deneme";
                writerManager.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }


    }
}

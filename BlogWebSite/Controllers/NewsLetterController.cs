using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;

namespace BlogWebSite.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager _newsletterManager = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            _newsletterManager.AddNewsLetter(p);
            return PartialView();
        }


    }
}

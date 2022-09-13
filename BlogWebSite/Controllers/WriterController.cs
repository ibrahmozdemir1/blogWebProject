using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
	public class WriterController : Controller
	{
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}

		[AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavBarPartial()
		{
			return PartialView();
		}
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
    }
}

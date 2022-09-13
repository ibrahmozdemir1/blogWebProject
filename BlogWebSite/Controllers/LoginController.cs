using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogWebSite.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                return View();
            }
            return View();
        }
    }
}
/* Context c = new Context();
        var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
        if(datavalue != null)
        {
            HttpContext.Session.SetString("username", p.WriterMail);
            return RedirectToAction("Index", "Writer");
        }
        else
        {
            return View();
        }*/
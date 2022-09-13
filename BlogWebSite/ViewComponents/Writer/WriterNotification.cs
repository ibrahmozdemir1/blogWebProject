using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

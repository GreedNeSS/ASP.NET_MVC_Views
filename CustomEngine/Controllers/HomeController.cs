using Microsoft.AspNetCore.Mvc;

namespace CustomEngine.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View("About");
        }

        public ViewResult Contacts()
        {
            return View();
        }
    }
}

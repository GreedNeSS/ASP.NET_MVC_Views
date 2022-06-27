using Microsoft.AspNetCore.Mvc;
using System;

namespace Forms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, int age, string[] languages)
        {
            return Json(new { Name = name, Age = age, Languages = new List<string>(languages)});
        }
    }
}

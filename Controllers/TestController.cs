using Microsoft.AspNetCore.Mvc;

namespace EZCourse.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }

    }
}
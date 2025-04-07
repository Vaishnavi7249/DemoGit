using Microsoft.AspNetCore.Mvc;

namespace DemoGit.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

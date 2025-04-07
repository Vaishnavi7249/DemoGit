using Microsoft.AspNetCore.Mvc;

namespace DemoGit.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

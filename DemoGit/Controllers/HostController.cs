using Microsoft.AspNetCore.Mvc;

namespace DemoGit.Controllers
{
    public class HostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

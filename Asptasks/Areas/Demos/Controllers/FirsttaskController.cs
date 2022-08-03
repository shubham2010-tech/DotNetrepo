using Microsoft.AspNetCore.Mvc;

namespace Asptasks.Areas.Demos.Controllers
{
    [Area("Demos")]
    public class FirsttaskController : Controller
    {
        public IActionResult Index()
        {
            return Ok("HII Baby");
        }

        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
    }
}

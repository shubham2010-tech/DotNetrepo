using Microsoft.AspNetCore.Mvc;

namespace LMS.WEB.Areas.Demos.Controllers
{
    [Area("Demos")]
    public class MyFirstDemoController : Controller
    {
        // GET https://localhost:44386/demos/myfirsdemo
        // GET https://localhost:44386/demos/myfirsdemo/index

        public IActionResult Index()
        {
            return Ok ("Hello World");
        }

        // GET https://localhost:44386/demos/myfirsdemo/index2
        public IActionResult Index2()
        {
            return View();
        }
    }
}

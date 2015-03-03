using Microsoft.AspNet.Mvc;

namespace Azure_DVLUP.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
        {
            return View();
        }
		public IActionResult Step1()
		{
			return View();
		}
		public IActionResult Step2()
		{
			return View();
		}
		public IActionResult Step3()
		{
			return View();
		}
	}
}

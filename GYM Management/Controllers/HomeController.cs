using Microsoft.AspNetCore.Mvc;

namespace GYM_Management.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult coach()
		{
			return View();
		}
	}
}

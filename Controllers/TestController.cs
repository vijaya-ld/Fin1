using Microsoft.AspNetCore.Mvc;

namespace Fin1.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

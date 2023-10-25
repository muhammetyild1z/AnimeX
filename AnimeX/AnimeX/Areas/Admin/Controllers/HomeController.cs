using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.Controllers
{
	public class HomeController : Controller
	{
        [Area("Admin")]
        public IActionResult Index()
		{
			return View();
		}
	}
}

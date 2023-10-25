using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.Controllers
{
	public class AdminLayoutController : Controller
	{
        [Area("Admin")]
        public IActionResult Index()
		{
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace AnimeX.Controllers
{
	public class CustomerLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult Indexw()
        {
            return View();
        }
    }
}

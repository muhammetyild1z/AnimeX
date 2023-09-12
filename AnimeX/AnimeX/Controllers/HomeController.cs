
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;

using AnimeX.EntityLayer;
using AnimeX.Models;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AnimeX.Controllers
{
	public class HomeController : Controller
	{
		//private readonly ILogger<HomeController> _logger;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

        private readonly AnimelerManager _animeManager;

        public HomeController(AnimelerManager animeManager)
        {
            _animeManager = animeManager;
        }

        // AnimelerManager anm = new AnimelerManager(new efAnimelerDal( new Context()));

        public IActionResult Index()
		{
					var a = _animeManager.TGetListAsync();

            return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
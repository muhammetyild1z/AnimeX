
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
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

		
         AnimelerManager anm = new AnimelerManager(new efAnimelerRepository( new Context()));
         CategoriesManager an = new CategoriesManager(new efCatagoriesRepository( new Context()));
         CategoryAnimeManeger ann = new CategoryAnimeManeger(new efCategoryAnimeRepository( new Context()));
		

        public IActionResult Index()
		{
		  
			
            return View( anm.TGetList());
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
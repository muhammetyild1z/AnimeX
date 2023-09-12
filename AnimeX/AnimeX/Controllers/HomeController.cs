using AnimeX.DataAccessLayer.Concrate;
using AnimeX.Models;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AnimeX.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			
			var context = new Context();

			var values= context.Animelers.ToList();
			//var b = context.Categories.ToList();
			//var d = values.Select(x => x.AnimeID);
			//var c= context.CategoryAnimes.Where(x=>x.animeler.AnimeID==1).Select(x=>x.KategoriID).ToList();
			
						   
			return View(values);
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
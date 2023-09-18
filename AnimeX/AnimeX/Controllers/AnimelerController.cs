using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace AnimeX.UI.Controllers
{
    public class AnimelerController : Controller
    {
        AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
        CategoriesManager amn = new CategoriesManager(new efCatagoriesRepository(new Context()));
        [HttpGet]
        public  IActionResult Index(int page = 1)
        {
            ViewBag.category = amn.TGetList().Select(x=>x.KategoriAdi);
            return View( am.TGetList().ToPagedList(page, 18));
            
        }
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }


    }
}

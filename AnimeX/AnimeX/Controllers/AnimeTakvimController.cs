using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeX.UI.Controllers
{
    public class AnimeTakvimController : Controller
    {
        AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
        public IActionResult Index()
        {
            var values=am.TGetList().Where(x=>x.AnimeCikisTarihi>DateTime.Now).OrderByDescending(x => x.AnimeCikisTarihi).ToList();
            return View(values);
        }
    }
}

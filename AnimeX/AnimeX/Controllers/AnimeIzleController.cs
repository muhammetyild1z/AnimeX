
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;

using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class AnimeIzleController : Controller
    {
        public IActionResult Izle(int AnimeID_Sezon)
        {
            AnimelerManager anm = new AnimelerManager(new efAnimelerRepository(new Context()));
            AnimeSezonManager am = new AnimeSezonManager(new efAnimeSezonRepository(new Context()));      
           var values = am.TGetList().Where(x=>x.Anime_ID_Sezon==AnimeID_Sezon).ToList();
            ViewBag.AnimeName = anm.TGetByID(AnimeID_Sezon).AnimeAdi;
            ViewBag.AnimeImg= values.Select(x=>x.SezonIzlekapakImg).FirstOrDefault();
            ViewBag.Sezonlar =values.Select(x=>x.Sezonlar).Distinct().ToList();
            return View(values);
        }
    }
}

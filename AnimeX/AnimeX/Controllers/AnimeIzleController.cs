
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;

using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class AnimeIzleController : Controller
    {
        public IActionResult Izle(int animeID)
        {
            
            AnimeSezonManager am = new AnimeSezonManager(new efAnimeSezonRepository(new Context()));      
            var values = am.TGetByID(animeID);
         
            return View(values);
        }
    }
}

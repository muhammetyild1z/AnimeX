using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnimeX.ViewComponents.SonEklenenBolumler
{
    public class _SonEklenenBolumler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            AnimeBolumsManager animeBolumManager = new AnimeBolumsManager(new efAnimeBolumsRepository(new Context()));
            AnimelerManager animeManager = new AnimelerManager(new efAnimelerRepository(new Context()));
            
            var values = animeBolumManager.TGetListIncludeBolumler().OrderByDescending(x=>x.BolumCreateDate).Take(6).ToList();


           // var animeID = animeManager.TGetList().Where(x => x.AnimeID == values.Select(x => x.AnimeID).ToList();
            return View(values);
        }
    }
}

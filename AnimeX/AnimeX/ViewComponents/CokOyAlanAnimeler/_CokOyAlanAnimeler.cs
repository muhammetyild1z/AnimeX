using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.CokOyAlanAnimeler
{
    public class _CokOyAlanAnimeler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            AnimeBolumsManager animeBolumManager = new AnimeBolumsManager(new efAnimeBolumsRepository(new Context()));        
            var values= animeBolumManager.TGetListIncludeBolumler().Where(x=>x.BolumCreateDate<DateTime.Now).DistinctBy(x=>x.animeler.AnimeAdi).Take(6).ToList();
            return View(values);
        }
    }
}

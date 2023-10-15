using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.AnimeIzleVideoPlayer
{
    public class _AnimeIzleVideoPlayer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //AnimeBolumsManager animeBolumManager = new AnimeBolumsManager(new efAnimeBolumsRepository(new Context()));
            //var values = animeBolumManager.TGetList()
            //    .Where(x=>x.BolumNo==bolumNo)
            //    .Where(x=>x.SezonsNo==sezonNo)
            //    .Where(x => x.BolumAnimeID == animeID).FirstOrDefault();

            
            return View();
        }
    }
}

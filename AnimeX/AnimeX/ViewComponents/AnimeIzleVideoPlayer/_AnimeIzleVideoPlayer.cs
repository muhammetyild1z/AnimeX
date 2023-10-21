using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.AnimeIzleVideoPlayer
{
    public class _AnimeIzleVideoPlayer:ViewComponent
    {
        public IViewComponentResult Invoke(int animeId , int bolumNo , int sezonNo)
        {
            AnimeBolumsManager animeBolumManager = new AnimeBolumsManager(new efAnimeBolumsRepository(new Context()));

            var values = animeBolumManager.TGetList().Where(x=>x.BolumAnimeID==animeId).Where(x=>x.SezonsNo==sezonNo).Where(x=>x.BolumNo==bolumNo).FirstOrDefault();
            
            return View(values);
        }
    }
}

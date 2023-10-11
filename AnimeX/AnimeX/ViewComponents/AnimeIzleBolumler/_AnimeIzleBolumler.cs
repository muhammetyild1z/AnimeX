using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.AnimeIzleBolumler
{
    public class _AnimeIzleBolumler:ViewComponent
    {
        AnimeBolumlerManager animeBolumManager = new AnimeBolumlerManager(new efAnimeBolumlerRepository(new Context()));
        public IViewComponentResult Invoke(int animeID)
        {
           
           var values = animeBolumManager.TGetList().Where(x => x.AnimeID == animeID).ToList();
            return View(values);
        }
    }
}

using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.AnimeIzleSezonlar
{
    public class _AnimeIzleSezonlar:ViewComponent
    {
        AnimeSezonlarManager animeSezonManager = new AnimeSezonlarManager(new efAnimeSezonlarRepository(new Context()));
        public IViewComponentResult Invoke(int animeID)
        {
            var values = animeSezonManager.TGetList().Where(x => x.AnimeID == animeID).ToList();
            return View(values);
        }
    }
}

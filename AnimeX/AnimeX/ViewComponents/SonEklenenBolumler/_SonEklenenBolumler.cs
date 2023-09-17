using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.SonEklenenBolumler
{
    public class _SonEklenenBolumler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //AnimeSezonManager anm = new AnimeSezonManager(new efAnimeSezonRepository(new Context()));
            //AnimelerManager anm = new AnimelerManager(new efAnimelerRepository(new Context()));
            //var values=anm.TGetList();

            return View();
        }
    }
}

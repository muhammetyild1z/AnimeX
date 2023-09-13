using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.SonCıkanAnimeler
{
    public class _SonCıkanAnimeler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
            var values = am.TGetList().OrderByDescending(x => x.AnimeEklenmeTarihi).Take(8).ToList();
            return View(values);
        }
    }
}

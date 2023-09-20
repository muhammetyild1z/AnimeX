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
            AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));

            return View(am.TGetList().OrderByDescending(x => x.IMDb).Where(x=>x.AnimeCikisTarihi<DateTime.Now).Take(10).ToList());
        }
    }
}

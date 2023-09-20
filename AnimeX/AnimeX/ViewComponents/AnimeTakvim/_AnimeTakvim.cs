using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.AnimeTakvim
{
    public class _AnimeTakvim:ViewComponent
    {
        AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
        public IViewComponentResult Invoke()
        {
            var values = am.TGetList().Where(x => x.AnimeCikisTarihi > DateTime.Now).Take(6).OrderBy(x=>x.AnimeCikisTarihi).ToList();
            return View(values);
        }
    }
}

using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeX.UI.ViewComponents.AnimeDetay
{
    public class _AnimeDetay:ViewComponent
    {
        public IViewComponentResult Invoke(int animeID)
        {
            AnimelerManager animeManager = new AnimelerManager(new efAnimelerRepository(new Context()));
            var value = animeManager.GetCommentIncludeAnimeler().Where(x=>x.AnimeID== animeID).FirstOrDefault();
            return View(value);
        }
    }
}

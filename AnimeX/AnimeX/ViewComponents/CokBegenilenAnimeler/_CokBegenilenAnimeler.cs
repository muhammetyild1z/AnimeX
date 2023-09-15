using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.CokIzlenenAnimeler
{
    public class _CokBegenilenAnimeler:ViewComponent
    {
        public IViewComponentResult Invoke( int id)
        {
            AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
          
            return View(am.TGetList().OrderByDescending(x => x.Like).Take(5).ToList());
        }
    }
}

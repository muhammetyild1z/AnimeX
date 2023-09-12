
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.Kategoriler
{
    public class _kategoriler : ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            CategoriesManager an = new CategoriesManager(new efCatagoriesRepository(new Context()));
            var values =  an.GetListCategoies();
            return View(values);
        }
    }
}

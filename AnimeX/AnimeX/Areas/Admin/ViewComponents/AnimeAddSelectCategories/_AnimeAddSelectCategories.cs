using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.ViewComponents.AnimeAddSelectCategories
{
    public class _AnimeAddSelectCategories:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoriesManager categoriesManager = new CategoriesManager(new efCatagoriesRepository(new Context()));
            var categories = categoriesManager.TGetList();
            return View(categories);
        }
    }
}

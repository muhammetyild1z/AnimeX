using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace AnimeX.UI.ViewComponents.AnimelerKategori
{
    public class _AnimelerKategori : ViewComponent
    {
        public IViewComponentResult Invoke(int animeID)
        {
            CategoriesManager cm = new CategoriesManager(new efCatagoriesRepository(new Context()));
            CategoryAnimeManeger cam = new CategoryAnimeManeger(new efCategoryAnimeRepository(new Context()));
            var catID = cam.GetCategoriesIncludecategoryAnime().Where(x => x.AnimeID == animeID).Take(2).ToList(); 
           

            return View(catID);
        }
    }
}

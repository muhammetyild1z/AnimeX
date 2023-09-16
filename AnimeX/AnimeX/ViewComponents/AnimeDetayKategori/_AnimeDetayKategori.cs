using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.AnimeDetayKategori
{
    public class _AnimeDetayKategori:ViewComponent
    {
        public IViewComponentResult Invoke(int animeID)
        {
            CategoryAnimeManeger cam = new CategoryAnimeManeger(new efCategoryAnimeRepository(new Context()));
            var catID = cam.GetCategoriesIncludecategoryAnime().Where(x => x.AnimeID == animeID).ToList();
           
            return View(catID);
        }
    }
}

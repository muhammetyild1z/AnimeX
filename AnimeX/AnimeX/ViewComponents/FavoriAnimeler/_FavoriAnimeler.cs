using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.FavoriAnimeler
{
    public class _FavoriAnimeler:ViewComponent
    {
        public IViewComponentResult Invoke(string UserName)
        {
            UserFavoriManager userFavoriManager = new UserFavoriManager(new efUserFavoriRepository(new DataAccessLayer.Concrate.Context()));
            
           var values = userFavoriManager.FavoriUserAnimelerGetListInclude().Where(x=>x.AppUser.UserName== UserName).ToList();
            
            return View(values);
        }
    }
}

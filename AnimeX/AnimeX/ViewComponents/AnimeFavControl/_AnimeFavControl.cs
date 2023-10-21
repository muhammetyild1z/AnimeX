using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AnimeX.UI.ViewComponents.AnimeFavControl
{
    public class _AnimeFavControl:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AnimeFavControl(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public  IViewComponentResult Invoke(int animeID )
        {

            var user = _userManager.Users.Where(x=>x.UserName==User.Identity.Name).Select(x=>x.Id).FirstOrDefault();
            if (User.Identity.IsAuthenticated==true)
            {
                UserFavoriManager userFavoriManager = new UserFavoriManager(new efUserFavoriRepository(new Context()));

               var value = userFavoriManager.GetList().Where(x => x.FavAnimeID == animeID).Where(x => x.FavUserId == user).Count();    
                ViewBag.FavAnime=value;
                ViewBag.AnimeID= animeID;
                return View();
            }
           
            return View();
        }
    }
}

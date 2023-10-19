using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AnimeX.UI.ViewComponents.AnimeFavoriControl
{
    public class _AnimeFavoriControl : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AnimeFavoriControl(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

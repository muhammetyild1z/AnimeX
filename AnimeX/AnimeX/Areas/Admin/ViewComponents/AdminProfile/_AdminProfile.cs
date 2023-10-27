using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.ViewComponents.Info4Box
{
    public class _AdminProfile:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminProfile(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {

            var user = _userManager.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            return View(user);
        
        }
    }
}

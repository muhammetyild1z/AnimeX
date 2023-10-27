using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.Controllers
{
	public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Area("Admin")]
		public async Task< IActionResult >Index()
		{
            var user =  await _userManager.GetUsersInRoleAsync("Member");
            return View(user);
		}
	}
}

using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AnimeX.UI.Controllers
{
    public class MyProfileController : Controller
    {
        UserManager<AppUser> _userManager;

        public MyProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value);

            return View(values);
        }
        [HttpGet]
        public IActionResult ProfileEdit(string userId )
        {

            var user = _userManager.FindByIdAsync(userId);
            
            return View(user);
        }
        [HttpPost]
        public IActionResult ProfileEdit()
        {

           
            return View();
        }
    }
}

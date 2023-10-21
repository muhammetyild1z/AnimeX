using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using AnimeX.DtoLayer.ProfileEditDto;
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
            
            if (User.Identity.IsAuthenticated == true)
            {
                var values = await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value);
                return View(values);
            }
            else
            {
                return RedirectToAction("SignIn", "Account");
            }


        }
        [HttpGet]
        public async Task<IActionResult> ProfileEdit()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return View("Error");
            }
            else if (true)
            {
                return View(user);
            }

        }
        [HttpPost]
        public async Task<IActionResult> ProfileEdit(ProfileEditDto userDto)
        {

            if (User.Identity.IsAuthenticated == true)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Email = user.Email;
                user.Details = user.Details;
                await _userManager.UpdateAsync(user);

                if (userDto.password != null || userDto.passwordR != null && userDto.passwordR== userDto.password)
                {
                    
                    var result = await _userManager.ChangePasswordAsync(user, userDto.Oldpassword, userDto.passwordR);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {

                            ModelState.AddModelError("", item.Description);
                        }
                        return View(user);
                    }
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }


        }
    }
}

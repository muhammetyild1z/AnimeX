using AnimeX.DtoLayer.AccountDto;
using AnimeX.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInDto siginDto)
        {

            var result =await _signInManager.PasswordSignInAsync(siginDto.UserName, siginDto.Password, true, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "MyProfile");

            }
            else
            {
                ViewBag.loginFailed = "Kullanici adi veya şifre hatalı.";
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SignUp( )
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto p)
        {
            if (p.Password==p.PasswordR)
            {
                AppUser user = new AppUser
                {
                    UserName = p.UserName,
                    Email = p.Email
                };
                var result = await _userManager.CreateAsync(user,p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Account");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            
            return View();
        }
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn", "Account");
        }
    }
}

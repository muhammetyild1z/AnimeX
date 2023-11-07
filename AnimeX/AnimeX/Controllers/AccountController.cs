using AnimeX.DtoLayer.AccountDto;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace AnimeX.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
       

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInDto siginDto)
        {
            var user= await _userManager.FindByNameAsync(siginDto.UserName);
            var result = await _signInManager.PasswordSignInAsync(siginDto.UserName, siginDto.Password, true, false);
            if (result.Succeeded)
            {
                if (await _userManager.IsInRoleAsync(user, "Admin") == true)
                {
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Index", "MyProfile");

            }     
            else
            {
                ViewBag.loginFailed = "Kullanici adi veya şifre hatalı.";
            }
            
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SignUp()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto p)
        {
            if (p.Password == p.PasswordR)
            {
                string emailHash = p.Email;
                byte[] encodedPassword = new UTF8Encoding().GetBytes(emailHash);
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                string encoded = BitConverter.ToString(hash)
                   .Replace("-", string.Empty)
                   .ToLower();

                AppUser user = new AppUser
                {
              
                UserName = p.UserName,
                    Email = p.Email,
                    UserImg = "https://r.resimlink.com/liu8Qk.jpg",
                    EmailHash = encoded+"?s=200",
                    Details = " Henuz Kendini Bize Anlatmamis..",
                    UserCreateDate = DateTime.Now
                };
            var result = await _userManager.CreateAsync(user, p.Password);
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

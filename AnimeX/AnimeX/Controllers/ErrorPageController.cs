using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Ups(int code)
        {
            return View();
        }
    }

}

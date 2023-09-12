using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class AnimelerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

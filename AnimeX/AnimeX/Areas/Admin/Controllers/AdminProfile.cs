using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.Controllers
{
    public class AdminProfile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

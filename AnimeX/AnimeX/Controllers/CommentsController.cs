using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class AnimelerController : Controller
    {
        public  IActionResult Index()
        {
            AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));

            return View( am.TGetList());
        }
    }
}

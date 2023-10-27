using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace AnimeX.UI.Areas.Admin.Controllers
{
    public class AdminAnimes : Controller
    {
        AnimelerManager animelerManager = new AnimelerManager(new efAnimelerRepository(new Context()));

        [Area("Admin")]
        public IActionResult Animelers(int page=1)
        {
           
            var values= animelerManager.TGetList().ToPagedList(page,14);
            return View(values);
        }
     
    }
}

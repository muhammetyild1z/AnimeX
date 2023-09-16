using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace AnimeX.UI.Controllers
{
    public class AnimelerController : Controller
    {
        AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
        public  IActionResult Index(int page = 1)
        {          
            return View( am.TGetList().ToPagedList(page, 18));
        }
        


    }
}

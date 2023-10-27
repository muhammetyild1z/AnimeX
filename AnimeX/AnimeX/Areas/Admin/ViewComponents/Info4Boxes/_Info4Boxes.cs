using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.ViewComponents.Info4Boxes
{
    public class _Info4Boxes:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _Info4Boxes(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
           
            AnimelerManager animelerManager = new AnimelerManager(new efAnimelerRepository(new Context()));
            CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));
            CategoriesManager categoryManager = new CategoriesManager(new efCatagoriesRepository(new Context()));
            
            ViewBag.CommentCount = commentManager.TGetList().Count();
            ViewBag.AnimeCount = animelerManager.TGetList().Count(); 
            ViewBag.CategoryCount = categoryManager.TGetList().Count();
            ViewBag.UserCount = _userManager.Users.Count();
            return View();
        }
    }
}

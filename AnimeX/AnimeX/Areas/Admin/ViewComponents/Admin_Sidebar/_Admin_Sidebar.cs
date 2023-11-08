using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.ViewComponents.Admin_Sidebar
{
    public class _Admin_Sidebar:ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;

        public _Admin_Sidebar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));
        public IViewComponentResult Invoke()
        {
            var user = _userManager.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            //ROLE GORE KONTROL YAP UYE KISI LINKLE ERISTIGINDE 404 FOUND SAYFASINA YONLENDIR..
            //    if ( _userManager.IsInRoleAsync(user, "Admin") == true)
            //    {
            //    return View(user);
            //}
            ViewBag.CommentFalse = commentManager.TGetList().Where(x => x.CommentStatus == false).Count();

            return View(user);
        }
    }
}

using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AnimeX.UI.ViewComponents.Comments
{
    public class _Comments : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        public _Comments(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke(int animeID)
        {

            CommentManager cm = new CommentManager(new efCommentRepository(new Context()));
            var comment = cm.TGetList().Where(x => x.AnimeCommentID == animeID).Where(x=>x.CommentStatus==true).OrderBy(x => x.CommentDate).ToList();
            ViewBag.animeID = animeID;       
             
           
                     
            return View(comment);
        }
    }
}

using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.ViewComponents.HeaderNotification
{
    public class _HeaderNotification:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));
        public IViewComponentResult Invoke()
        {
         var  notificationComments = commentManager.CommentAnimelerInclude().Where(x=>x.CommentStatus==false).ToList();
            return View(notificationComments);
        }
    }
}

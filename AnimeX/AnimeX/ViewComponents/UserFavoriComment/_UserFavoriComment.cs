using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.UserFavoriComment
{
    public class _UserFavoriComment:ViewComponent
    {
        public IViewComponentResult Invoke(string UserName)
        {
            CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));

            var values = commentManager.CommentAnimelerInclude().Where(x=>x.UserName== UserName).ToList();
            return View(values);
        }
    }
}
